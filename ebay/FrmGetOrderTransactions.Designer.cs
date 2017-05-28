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
            this.TxtItemId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGetOrders
            // 
            this.BtnGetOrders.Location = new System.Drawing.Point(274, 90);
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
            // TxtItemId
            // 
            this.TxtItemId.Location = new System.Drawing.Point(84, 12);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.Size = new System.Drawing.Size(120, 25);
            this.TxtItemId.TabIndex = 106;
            // 
            // FrmGetOrderTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 538);
            this.Controls.Add(this.LblItemId);
            this.Controls.Add(this.TxtItemId);
            this.Controls.Add(this.BtnGetOrders);
            this.Name = "FrmGetOrderTransactions";
            this.Text = "FrmGetOrderTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGetOrders;
        private System.Windows.Forms.Label LblItemId;
        private System.Windows.Forms.TextBox TxtItemId;
    }
}