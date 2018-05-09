using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.Threading;
using System.Text.RegularExpressions;

namespace ecommerce_help
{
    public partial class frmMain : Form
    {
        private const string _target = "130.1.1.15";
        private const string _user = "root";
        private const string _pwd = "Pycca5689";
        private const string _command91 = "/usr/bin/java -jar /root/scripts/VTEXMigrate/dist/VTEXMigrate.jar 91";
        private const string _command41 = "/usr/bin/java -jar /root/scripts/VTEXMigrate/dist/VTEXMigrate.jar 41";
        private const string _command51 = "/usr/bin/java -jar /root/scripts/VTEXMigrate/dist/VTEXMigrate.jar 51";

        private bool _resExec = false;
        private string _resOutput = String.Empty;
        private bool _startProcess = false;

        private List<bool> _stateds;
        private List<string> _sku;
        private List<string> _response_stock;
        private List<string> _response_price;

        public frmMain()
        {
            InitializeComponent();
            _stateds = new List<bool>();
            _sku = new List<string>();
            _response_stock = new List<string>();
            _response_price = new List<string>();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btExec91_Click(object sender, EventArgs e)
        {
            _resExec = false;
            _resOutput = String.Empty;
            try
            {
                ThreadStart mydel = retMyDelegate();
                Thread th = new Thread(mydel);
                th.Start();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private ThreadStart retMyDelegate()
        {
            return delegate
            {
                ExecMyProcess();
            };
        }

        private void ExecMyProcess()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = delegate { ExecMyProcess(); };
                _startProcess = true;
                this.Invoke(method);
                using (var sshclient = new SshClient(_target, 22, _user, _pwd))
                {
                    sshclient.Connect();
                    using (var cmd = sshclient.CreateCommand(_command91))
                    {
                        cmd.Execute();
                        _resExec = (cmd.ExitStatus == 0) ? true : false;
                        _resOutput = cmd.Result;
                    }
                    sshclient.Disconnect();
                }
                _startProcess = false;
                this.Invoke(method);
            }
            else
            {
                if (_startProcess)
                {
                    this.picWait.Visible = true;
                    this.lbExecuting.Visible = true;
                }
                else
                {
                    this.picWait.Visible = false;
                    this.lbExecuting.Visible = false;
                    if (_resExec)
                    {
                        MessageBox.Show("El proceso de actualización de articulos ha terminado exitosamente", "Ecommerce help Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txOutput.AppendText(_resOutput);
                        btContinue.Text = "Ahora si, continuemos";
                        btExec91.Text = "Actualizar nuevamente";
                    }
                    else
                    {
                        MessageBox.Show("Ups! algo salio mal", "Ecommerce help Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txOutput.AppendText(_resOutput);
                    }
                }
                
            }
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            grStep1.Visible = false;
            grStep2.Visible = true;
            txSKU.Focus();
        }

        private void btAddOne_Click(object sender, EventArgs e)
        {
            addOne(txSKU.Text.Trim());
        }

        private ThreadStart retStockPriceDelegate(int _index)
        {
            return delegate
            {
                ExecStockPriceProcess(_index);
            };
        }

        private void btAddMore_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                DataObject objClip = (DataObject)Clipboard.GetDataObject();
                string[] selectedRows = Regex.Split(objClip.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                if (selectedRows.Length > 0)
                {
                    foreach(string sku in selectedRows)
                    {
                        addOne(sku);
                    }
                }
            }
        }

        private void btStartProcess_Click(object sender, EventArgs e)
        {
            int _ocurrences = dgvSKU.Rows.Count;
            this._sku.Clear();
            for (int i=0; i< _ocurrences; i++)
            {
                this._stateds.Add(false);
                this._sku.Add(this.dgvSKU.Rows[i].Cells[0].Value.ToString());
                this._response_stock.Add(String.Empty);
                this._response_price.Add(String.Empty);
            }

            //Parallel.For(0, _ocurrences, i =>
            for (int i = 0; i < _ocurrences; i++)
            {
                this._stateds[i] = false;
                ThreadStart mydel = retStockPriceDelegate(i);
                Thread th = new Thread(mydel);
                th.Start();
            }
        }

        private void addOne(string sku)
        {
            if (!sku.Equals(String.Empty))
            {
                var matches = _sku.Where(x => x == sku).ToList();
                if (matches.Count >0)
                {
                    MessageBox.Show("El artícilo " + sku + ", ya se encuentra en la lista de actualización", "Ecommerce help Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string desc = getProductDesc(sku);
                if (desc != "")
                {
                    int item = dgvSKU.Rows.Add();
                    dgvSKU.Rows[item].Cells[0].Value = sku;
                    dgvSKU.Rows[item].Cells[1].Value = getProductDesc(sku);
                    dgvSKU.Rows[item].Cells[2].Value = String.Format("{0:C}", 0);
                    dgvSKU.Rows[item].Cells[3].Value = "0";
                    dgvSKU.Rows[item].Cells[4].Value = global::ecommerce_help.Properties.Resources.less;
                    _sku.Add(sku);
                    txSKU.Text = String.Empty;
                    txSKU.Focus();
                }
                else
                {
                    MessageBox.Show("Upps! no encontramos el artículo " + sku + ", talves se agregó recien a VTEX. Prueba actualizar los artículos en la pantalla anterior ", "Ecommerce help Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private string getProductDesc(string sku)
        {
            string response = String.Empty;
            using (DataFactory my = new SqlFactory())
            {
                DataSet outData = new DataSet();
                my.ExecQuery("PODBPOS", "SELECT nombre FROM IVDBINVENTAR.vtex.ivtbarticulo_web WHERE co_articulo='" + sku+"'", out outData);
                if (outData != null)
                {
                    if (outData.Tables[0] != null)
                    {
                        if (outData.Tables[0].Rows.Count > 0)
                        {
                            response = outData.Tables[0].Rows[0][0].ToString();
                        }                        
                    }
                }
            }
            return response;
        }

        private void txSKU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                addOne(txSKU.Text.Trim());
            }
        }


        private void ExecStockPriceProcess(int _index)
        {
            if (InvokeRequired)
            {
                MethodInvoker stockPrice = delegate { ExecStockPriceProcess(_index); };

                _stateds[_index] = true;

                this.Invoke(stockPrice);

                using (var sshclient = new SshClient(_target, 22, _user, _pwd))
                {
                    sshclient.Connect();
                    using (var cmd = sshclient.CreateCommand(_command41 + " " + _sku[_index]))
                    {
                        do
                        {
                            cmd.Execute();
                            _resExec = (cmd.ExitStatus == 0) ? true : false;
                            _response_price[_index] = cmd.Result;
                        } while (_response_price[_index].Contains("otra instancia de la aplicación se está ejecutando"));
                    }
                    sshclient.Disconnect();
                }

                using (var sshclient = new SshClient(_target, 22, _user, _pwd))
                {
                    sshclient.Connect();
                    using (var cmd = sshclient.CreateCommand(_command51 + " " + _sku[_index]))
                    {
                        do { 
                            cmd.Execute();
                            _resExec = (cmd.ExitStatus == 0) ? true : false;
                            _response_stock[_index] = cmd.Result;
                       } while (_response_price[_index].Contains("otra instancia de la aplicación se está ejecutando")) ;
                    }
                    sshclient.Disconnect();
                }
                _stateds[_index] = false;
                this.Invoke(stockPrice);
            }
            else
            {
                if (_stateds[_index])
                {
                    dgvSKU.Rows[_index].Cells[4].Value = global::ecommerce_help.Properties.Resources.clock;
                }
                else
                {
                    dgvSKU.Rows[_index].Cells[4].Value = global::ecommerce_help.Properties.Resources.check;
                    string strPrice = _response_price[_index];
                    int from = strPrice.IndexOf("RESPONSE:");
                    int to = 0;
                    if (from > 0)
                    {
                        strPrice = strPrice.Substring(from);
                        to = strPrice.IndexOf("END")-32;
                        strPrice = strPrice.Substring(11,to);
                        string price = strPrice.Split(',')[3];
                        price = price.Substring(price.IndexOf(':')+1);
                        dgvSKU.Rows[_index].Cells[2].Value = String.Format("{0:C}", Math.Round(Double.Parse(price),2));

                    }
                    string strStock = _response_stock[_index];
                    from = strStock.IndexOf("quantity");
                    if (from > 0)
                    {
                        strStock = strStock.Substring(from);
                        to = strStock.IndexOf("}") - 11;
                        strStock = strStock.Substring(10,to);
                        dgvSKU.Rows[_index].Cells[3].Value = int.Parse(strStock).ToString();
                    }
                }
                  
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSKU.SelectedRows.Count > 0)
            { 
                DataGridViewRow item = dgvSKU.SelectedRows[0];
                int ix = item.Index;
                if (ix >= 0)
                {
                    dgvSKU.Rows.RemoveAt(ix);
                    _sku.RemoveAt(ix);
                }
            }
        }

        private void dgvSKU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int ocurrs = e.RowIndex + 1;
                frmResponse edt = new frmResponse();
                edt.response_vtex = _response_price[e.RowIndex]+"\n\n"+_response_stock[e.RowIndex];
                edt.ShowDialog();
            }
        }
    }
}
