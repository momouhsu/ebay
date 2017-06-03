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
            this.TxtItemID = new System.Windows.Forms.TextBox();
            this.TxtXml = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTransactionID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOrderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOrderLineItemID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGetOrders
            // 
            this.BtnGetOrders.Location = new System.Drawing.Point(84, 84);
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
            this.LblItemId.Text = "ItemID:";
            // 
            // TxtItemID
            // 
            this.TxtItemID.Location = new System.Drawing.Point(84, 12);
            this.TxtItemID.Name = "TxtItemID";
            this.TxtItemID.Size = new System.Drawing.Size(245, 25);
            this.TxtItemID.TabIndex = 106;
            // 
            // TxtXml
            // 
            this.TxtXml.Location = new System.Drawing.Point(84, 132);
            this.TxtXml.Multiline = true;
            this.TxtXml.Name = "TxtXml";
            this.TxtXml.Size = new System.Drawing.Size(1147, 515);
            this.TxtXml.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 110;
            this.label2.Text = "response:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(362, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 112;
            this.label1.Text = "TransactionID:";
            // 
            // TxtTransactionID
            // 
            this.TxtTransactionID.Location = new System.Drawing.Point(499, 9);
            this.TxtTransactionID.Name = "TxtTransactionID";
            this.TxtTransactionID.Size = new System.Drawing.Size(245, 25);
            this.TxtTransactionID.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 114;
            this.label3.Text = "OrderID:";
            // 
            // TxtOrderID
            // 
            this.TxtOrderID.Location = new System.Drawing.Point(84, 43);
            this.TxtOrderID.Name = "TxtOrderID";
            this.TxtOrderID.Size = new System.Drawing.Size(245, 25);
            this.TxtOrderID.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(362, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 116;
            this.label4.Text = "OrderLineItemID:";
            // 
            // TxtOrderLineItemID
            // 
            this.TxtOrderLineItemID.Location = new System.Drawing.Point(499, 40);
            this.TxtOrderLineItemID.Name = "TxtOrderLineItemID";
            this.TxtOrderLineItemID.Size = new System.Drawing.Size(245, 25);
            this.TxtOrderLineItemID.TabIndex = 115;
            // 
            // FrmGetOrderTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 659);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtOrderLineItemID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTransactionID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtXml);
            this.Controls.Add(this.LblItemId);
            this.Controls.Add(this.TxtItemID);
            this.Controls.Add(this.BtnGetOrders);
            this.Name = "FrmGetOrderTransactions";
            this.Text = "FrmGetOrderTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGetOrders;
        private System.Windows.Forms.Label LblItemId;
        private System.Windows.Forms.TextBox TxtItemID;
        private System.Windows.Forms.TextBox TxtXml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTransactionID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOrderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOrderLineItemID;
    }
}