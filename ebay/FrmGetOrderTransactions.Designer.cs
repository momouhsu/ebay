namespace ebay
{
    partial class FrmGetOrderTransactions
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
            this.BtnGetOrders = new System.Windows.Forms.Button();
            this.LblItemId = new System.Windows.Forms.Label();
            this.TxtTransid = new System.Windows.Forms.TextBox();
            this.TxtXml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGetOrders
            // 
            this.BtnGetOrders.Location = new System.Drawing.Point(84, 63);
            this.BtnGetOrders.Name = "BtnGetOrders";
            this.BtnGetOrders.Size = new System.Drawing.Size(154, 32);
            this.BtnGetOrders.TabIndex = 105;
            this.BtnGetOrders.Text = "GetItemTransactions";
            this.BtnGetOrders.Click += new System.EventHandler(this.BtnGetOrders_Click);
            // 
            // LblItemId
            // 
            this.LblItemId.Location = new System.Drawing.Point(17, 12);
            this.LblItemId.Name = "LblItemId";
            this.LblItemId.Size = new System.Drawing.Size(67, 22);
            this.LblItemId.TabIndex = 107;
            this.LblItemId.Text = "Order Id:";
            // 
            // TxtTransid
            // 
            this.TxtTransid.Location = new System.Drawing.Point(84, 12);
            this.TxtTransid.Name = "TxtTransid";
            this.TxtTransid.Size = new System.Drawing.Size(593, 25);
            this.TxtTransid.TabIndex = 106;
            this.TxtTransid.Text = "201702147986-1528357347010";
            // 
            // TxtXml
            // 
            this.TxtXml.Location = new System.Drawing.Point(84, 101);
            this.TxtXml.Multiline = true;
            this.TxtXml.Name = "TxtXml";
            this.TxtXml.Size = new System.Drawing.Size(798, 410);
            this.TxtXml.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 109;
            this.label1.Text = "ex:201702147986-1528357347010";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 110;
            this.label2.Text = "response:";
            // 
            // FrmGetOrderTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtXml);
            this.Controls.Add(this.LblItemId);
            this.Controls.Add(this.TxtTransid);
            this.Controls.Add(this.BtnGetOrders);
            this.Name = "FrmGetOrderTransactions";
            this.Text = "FrmGetOrderTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGetOrders;
        private System.Windows.Forms.Label LblItemId;
        private System.Windows.Forms.TextBox TxtTransid;
        private System.Windows.Forms.TextBox TxtXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}