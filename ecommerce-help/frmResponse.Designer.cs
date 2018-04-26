namespace ecommerce_help
{
    partial class frmResponse
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
            this.txResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txResponse
            // 
            this.txResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txResponse.Location = new System.Drawing.Point(0, -1);
            this.txResponse.Name = "txResponse";
            this.txResponse.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txResponse.Size = new System.Drawing.Size(591, 386);
            this.txResponse.TabIndex = 0;
            this.txResponse.Text = "";
            // 
            // frmResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 381);
            this.Controls.Add(this.txResponse);
            this.MaximizeBox = false;
            this.Name = "frmResponse";
            this.Text = "Respuesta desde VTEX";
            this.Load += new System.EventHandler(this.frmResponse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txResponse;
    }
}