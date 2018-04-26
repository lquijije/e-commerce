using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ecommerce_help
{
    public partial class frmResponse : Form
    {
        public string response_vtex
        { get; set; }
        public frmResponse()
        {
            InitializeComponent();
        }

        private void frmResponse_Load(object sender, EventArgs e)
        {
            txResponse.Text = response_vtex;
        }
    }
}
