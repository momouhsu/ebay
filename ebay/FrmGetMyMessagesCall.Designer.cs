namespace ebay
{
    partial class FrmGetMyMessagesCall
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtXml = new System.Windows.Forms.TextBox();
            this.BtnGetMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 113;
            this.label2.Text = "response:";
            // 
            // TxtXml
            // 
            this.TxtXml.Location = new System.Drawing.Point(75, 51);
            this.TxtXml.Multiline = true;
            this.TxtXml.Name = "TxtXml";
            this.TxtXml.Size = new System.Drawing.Size(798, 588);
            this.TxtXml.TabIndex = 112;
            // 
            // BtnGetMessage
            // 
            this.BtnGetMessage.Location = new System.Drawing.Point(75, 13);
            this.BtnGetMessage.Name = "BtnGetMessage";
            this.BtnGetMessage.Size = new System.Drawing.Size(154, 32);
            this.BtnGetMessage.TabIndex = 111;
            this.BtnGetMessage.Text = "GetMyMessagesCall";
            this.BtnGetMessage.Click += new System.EventHandler(this.BtnGetMessage_Click);
            // 
            // FrmGetMyMessagesCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 688);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtXml);
            this.Controls.Add(this.BtnGetMessage);
            this.Name = "FrmGetMyMessagesCall";
            this.Text = "FrmGetMyMessagesCall";
            this.Load += new System.EventHandler(this.FrmGetMyMessagesCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtXml;
        private System.Windows.Forms.Button BtnGetMessage;
    }
}