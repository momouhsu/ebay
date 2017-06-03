namespace ebay
{
    partial class FrmXml
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
            this.TxtXml = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtXml
            // 
            this.TxtXml.Location = new System.Drawing.Point(12, 12);
            this.TxtXml.Multiline = true;
            this.TxtXml.Name = "TxtXml";
            this.TxtXml.Size = new System.Drawing.Size(1172, 607);
            this.TxtXml.TabIndex = 109;
            // 
            // FrmXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 640);
            this.Controls.Add(this.TxtXml);
            this.Name = "FrmXml";
            this.Text = "FrmXml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtXml;
    }
}