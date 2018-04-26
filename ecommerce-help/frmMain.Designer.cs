namespace ecommerce_help
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grStep1 = new System.Windows.Forms.GroupBox();
            this.lbExecuting = new System.Windows.Forms.Label();
            this.picWait = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btExec91 = new System.Windows.Forms.Button();
            this.btContinue = new System.Windows.Forms.Button();
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.grStep2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btStartProcess = new System.Windows.Forms.Button();
            this.btAddMore = new System.Windows.Forms.Button();
            this.btAddOne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txSKU = new System.Windows.Forms.TextBox();
            this.dgvSKU = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewImageColumn();
            this.respuesta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbTit2 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.grStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            this.grStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKU)).BeginInit();
            this.SuspendLayout();
            // 
            // grStep1
            // 
            this.grStep1.Controls.Add(this.lbExecuting);
            this.grStep1.Controls.Add(this.picWait);
            this.grStep1.Controls.Add(this.label2);
            this.grStep1.Controls.Add(this.txOutput);
            this.grStep1.Controls.Add(this.label1);
            this.grStep1.Controls.Add(this.btExec91);
            this.grStep1.Controls.Add(this.btContinue);
            this.grStep1.Controls.Add(this.lbTitle1);
            this.grStep1.Location = new System.Drawing.Point(1, 22);
            this.grStep1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grStep1.Name = "grStep1";
            this.grStep1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grStep1.Size = new System.Drawing.Size(904, 619);
            this.grStep1.TabIndex = 0;
            this.grStep1.TabStop = false;
            // 
            // lbExecuting
            // 
            this.lbExecuting.BackColor = System.Drawing.Color.White;
            this.lbExecuting.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbExecuting.Location = new System.Drawing.Point(408, 406);
            this.lbExecuting.Name = "lbExecuting";
            this.lbExecuting.Size = new System.Drawing.Size(128, 25);
            this.lbExecuting.TabIndex = 7;
            this.lbExecuting.Text = "Executing....";
            this.lbExecuting.Visible = false;
            // 
            // picWait
            // 
            this.picWait.BackColor = System.Drawing.Color.White;
            this.picWait.Image = global::ecommerce_help.Properties.Resources.waiting_animation;
            this.picWait.Location = new System.Drawing.Point(421, 337);
            this.picWait.Name = "picWait";
            this.picWait.Size = new System.Drawing.Size(59, 66);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWait.TabIndex = 6;
            this.picWait.TabStop = false;
            this.picWait.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output process:";
            // 
            // txOutput
            // 
            this.txOutput.BackColor = System.Drawing.Color.White;
            this.txOutput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txOutput.Location = new System.Drawing.Point(37, 232);
            this.txOutput.Multiline = true;
            this.txOutput.Name = "txOutput";
            this.txOutput.ReadOnly = true;
            this.txOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txOutput.Size = new System.Drawing.Size(838, 355);
            this.txOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 25.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Antes de continuar......";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExec91
            // 
            this.btExec91.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btExec91.ForeColor = System.Drawing.Color.OliveDrab;
            this.btExec91.Location = new System.Drawing.Point(180, 141);
            this.btExec91.Name = "btExec91";
            this.btExec91.Size = new System.Drawing.Size(264, 43);
            this.btExec91.TabIndex = 2;
            this.btExec91.Text = "Si, Actualizar por favor";
            this.btExec91.UseVisualStyleBackColor = true;
            this.btExec91.Click += new System.EventHandler(this.btExec91_Click);
            // 
            // btContinue
            // 
            this.btContinue.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btContinue.ForeColor = System.Drawing.Color.SteelBlue;
            this.btContinue.Location = new System.Drawing.Point(450, 141);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(264, 43);
            this.btContinue.TabIndex = 1;
            this.btContinue.Text = "No, no hay ninguno pendiente";
            this.btContinue.UseVisualStyleBackColor = true;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // lbTitle1
            // 
            this.lbTitle1.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.lbTitle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbTitle1.Location = new System.Drawing.Point(7, 76);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(890, 31);
            this.lbTitle1.TabIndex = 0;
            this.lbTitle1.Text = "¿Has agregado algún producto nuevo en VTEX?";
            this.lbTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grStep2
            // 
            this.grStep2.Controls.Add(this.btnDelete);
            this.grStep2.Controls.Add(this.btStartProcess);
            this.grStep2.Controls.Add(this.btAddMore);
            this.grStep2.Controls.Add(this.btAddOne);
            this.grStep2.Controls.Add(this.label3);
            this.grStep2.Controls.Add(this.txSKU);
            this.grStep2.Controls.Add(this.dgvSKU);
            this.grStep2.Controls.Add(this.lbTit2);
            this.grStep2.Location = new System.Drawing.Point(1, 22);
            this.grStep2.Name = "grStep2";
            this.grStep2.Size = new System.Drawing.Size(904, 619);
            this.grStep2.TabIndex = 11;
            this.grStep2.TabStop = false;
            this.grStep2.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::ecommerce_help.Properties.Resources.if_trash_can_delete_44014;
            this.btnDelete.Location = new System.Drawing.Point(508, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 52);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btStartProcess
            // 
            this.btStartProcess.BackColor = System.Drawing.Color.SteelBlue;
            this.btStartProcess.FlatAppearance.BorderSize = 0;
            this.btStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartProcess.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartProcess.ForeColor = System.Drawing.Color.White;
            this.btStartProcess.Location = new System.Drawing.Point(46, 527);
            this.btStartProcess.Name = "btStartProcess";
            this.btStartProcess.Size = new System.Drawing.Size(783, 49);
            this.btStartProcess.TabIndex = 6;
            this.btStartProcess.Text = "Subir Precio y Stock";
            this.btStartProcess.UseVisualStyleBackColor = false;
            this.btStartProcess.Click += new System.EventHandler(this.btStartProcess_Click);
            // 
            // btAddMore
            // 
            this.btAddMore.Image = global::ecommerce_help.Properties.Resources.if_file_download_40776;
            this.btAddMore.Location = new System.Drawing.Point(565, 76);
            this.btAddMore.Name = "btAddMore";
            this.btAddMore.Size = new System.Drawing.Size(52, 52);
            this.btAddMore.TabIndex = 5;
            this.btAddMore.UseVisualStyleBackColor = true;
            this.btAddMore.Click += new System.EventHandler(this.btAddMore_Click);
            // 
            // btAddOne
            // 
            this.btAddOne.Image = global::ecommerce_help.Properties.Resources.if_list_add_118777;
            this.btAddOne.Location = new System.Drawing.Point(450, 76);
            this.btAddOne.Name = "btAddOne";
            this.btAddOne.Size = new System.Drawing.Size(52, 52);
            this.btAddOne.TabIndex = 4;
            this.btAddOne.UseVisualStyleBackColor = true;
            this.btAddOne.Click += new System.EventHandler(this.btAddOne_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Open Sans", 20.25F);
            this.label3.Location = new System.Drawing.Point(39, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 47);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código / artículo:";
            // 
            // txSKU
            // 
            this.txSKU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txSKU.Font = new System.Drawing.Font("Open Sans", 23.25F);
            this.txSKU.Location = new System.Drawing.Point(280, 76);
            this.txSKU.MaxLength = 6;
            this.txSKU.Name = "txSKU";
            this.txSKU.Size = new System.Drawing.Size(164, 50);
            this.txSKU.TabIndex = 2;
            this.txSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txSKU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSKU_KeyPress);
            // 
            // dgvSKU
            // 
            this.dgvSKU.AllowUserToAddRows = false;
            this.dgvSKU.AllowUserToDeleteRows = false;
            this.dgvSKU.AllowUserToResizeColumns = false;
            this.dgvSKU.AllowUserToResizeRows = false;
            this.dgvSKU.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSKU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSKU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.precio,
            this.stock,
            this.estado,
            this.respuesta});
            this.dgvSKU.GridColor = System.Drawing.Color.White;
            this.dgvSKU.Location = new System.Drawing.Point(46, 134);
            this.dgvSKU.Name = "dgvSKU";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSKU.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSKU.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSKU.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSKU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSKU.Size = new System.Drawing.Size(783, 387);
            this.dgvSKU.TabIndex = 1;
            this.dgvSKU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSKU_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 350;
            // 
            // precio
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // respuesta
            // 
            this.respuesta.HeaderText = "...";
            this.respuesta.Name = "respuesta";
            this.respuesta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.respuesta.Text = "...";
            this.respuesta.UseColumnTextForButtonValue = true;
            this.respuesta.Width = 30;
            // 
            // lbTit2
            // 
            this.lbTit2.Font = new System.Drawing.Font("Open Sans", 25.25F);
            this.lbTit2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbTit2.Location = new System.Drawing.Point(2, 12);
            this.lbTit2.Name = "lbTit2";
            this.lbTit2.Size = new System.Drawing.Size(898, 52);
            this.lbTit2.TabIndex = 0;
            this.lbTit2.Text = "Actualicemos el precio y el stock";
            this.lbTit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btClose
            // 
            this.btClose.Image = global::ecommerce_help.Properties.Resources.icons8_close_window_32;
            this.btClose.Location = new System.Drawing.Point(870, 1);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(28, 28);
            this.btClose.TabIndex = 10;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.Image = global::ecommerce_help.Properties.Resources.icons8_minimize_window_32;
            this.btMinimize.Location = new System.Drawing.Point(839, 1);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(28, 28);
            this.btMinimize.TabIndex = 9;
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 640);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.grStep2);
            this.Controls.Add(this.grStep1);
            this.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grStep1.ResumeLayout(false);
            this.grStep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            this.grStep2.ResumeLayout(false);
            this.grStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grStep1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Label lbTitle1;
        private System.Windows.Forms.Button btExec91;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbExecuting;
        private System.Windows.Forms.PictureBox picWait;
        private System.Windows.Forms.GroupBox grStep2;
        private System.Windows.Forms.Label lbTit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSKU;
        private System.Windows.Forms.DataGridView dgvSKU;
        private System.Windows.Forms.Button btAddOne;
        private System.Windows.Forms.Button btStartProcess;
        private System.Windows.Forms.Button btAddMore;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewImageColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn respuesta;
        private System.Windows.Forms.Button btnDelete;
    }
}

