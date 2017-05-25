namespace ebay
{
    partial class FrmGetOrders
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
            this.LblTimeRange = new System.Windows.Forms.Label();
            this.CboRole = new System.Windows.Forms.ComboBox();
            this.LblRole = new System.Windows.Forms.Label();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.DatePickStartTo = new System.Windows.Forms.DateTimePicker();
            this.DatePickStartFrom = new System.Windows.Forms.DateTimePicker();
            this.LblStartSep = new System.Windows.Forms.Label();
            this.GrpResult = new System.Windows.Forms.GroupBox();
            this.LblOrders = new System.Windows.Forms.Label();
            this.LstOrders = new System.Windows.Forms.ListView();
            this.ClmOrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmCreator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmSaved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnGetOrders = new System.Windows.Forms.Button();
            this.GrpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTimeRange
            // 
            this.LblTimeRange.Location = new System.Drawing.Point(31, 85);
            this.LblTimeRange.Name = "LblTimeRange";
            this.LblTimeRange.Size = new System.Drawing.Size(87, 22);
            this.LblTimeRange.TabIndex = 103;
            this.LblTimeRange.Text = "Time Filter:";
            // 
            // CboRole
            // 
            this.CboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboRole.Location = new System.Drawing.Point(127, 51);
            this.CboRole.Name = "CboRole";
            this.CboRole.Size = new System.Drawing.Size(173, 23);
            this.CboRole.TabIndex = 102;
            // 
            // LblRole
            // 
            this.LblRole.Location = new System.Drawing.Point(31, 51);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(96, 25);
            this.LblRole.TabIndex = 101;
            this.LblRole.Text = "Role:";
            // 
            // CboStatus
            // 
            this.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStatus.Location = new System.Drawing.Point(127, 18);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(173, 23);
            this.CboStatus.TabIndex = 100;
            // 
            // LblStatus
            // 
            this.LblStatus.Location = new System.Drawing.Point(31, 18);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(96, 25);
            this.LblStatus.TabIndex = 99;
            this.LblStatus.Text = "Status:";
            // 
            // DatePickStartTo
            // 
            this.DatePickStartTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DatePickStartTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickStartTo.Location = new System.Drawing.Point(358, 85);
            this.DatePickStartTo.Name = "DatePickStartTo";
            this.DatePickStartTo.Size = new System.Drawing.Size(163, 25);
            this.DatePickStartTo.TabIndex = 98;
            // 
            // DatePickStartFrom
            // 
            this.DatePickStartFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DatePickStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickStartFrom.Location = new System.Drawing.Point(127, 86);
            this.DatePickStartFrom.Name = "DatePickStartFrom";
            this.DatePickStartFrom.Size = new System.Drawing.Size(164, 25);
            this.DatePickStartFrom.TabIndex = 97;
            // 
            // LblStartSep
            // 
            this.LblStartSep.Location = new System.Drawing.Point(319, 85);
            this.LblStartSep.Name = "LblStartSep";
            this.LblStartSep.Size = new System.Drawing.Size(19, 31);
            this.LblStartSep.TabIndex = 96;
            this.LblStartSep.Text = " - ";
            // 
            // GrpResult
            // 
            this.GrpResult.Controls.Add(this.LblOrders);
            this.GrpResult.Controls.Add(this.LstOrders);
            this.GrpResult.Location = new System.Drawing.Point(22, 173);
            this.GrpResult.Name = "GrpResult";
            this.GrpResult.Size = new System.Drawing.Size(652, 321);
            this.GrpResult.TabIndex = 95;
            this.GrpResult.TabStop = false;
            this.GrpResult.Text = "Result";
            // 
            // LblOrders
            // 
            this.LblOrders.Location = new System.Drawing.Point(10, 33);
            this.LblOrders.Name = "LblOrders";
            this.LblOrders.Size = new System.Drawing.Size(134, 32);
            this.LblOrders.TabIndex = 12;
            this.LblOrders.Text = "Orders:";
            // 
            // LstOrders
            // 
            this.LstOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmOrderId,
            this.ClmStatus,
            this.ClmCreator,
            this.ClmSaved,
            this.ClmItems});
            this.LstOrders.GridLines = true;
            this.LstOrders.Location = new System.Drawing.Point(10, 78);
            this.LstOrders.Name = "LstOrders";
            this.LstOrders.Size = new System.Drawing.Size(624, 232);
            this.LstOrders.TabIndex = 13;
            this.LstOrders.UseCompatibleStateImageBehavior = false;
            this.LstOrders.View = System.Windows.Forms.View.Details;
            // 
            // ClmOrderId
            // 
            this.ClmOrderId.Text = "Order Id";
            this.ClmOrderId.Width = 95;
            // 
            // ClmStatus
            // 
            this.ClmStatus.Text = "Status";
            this.ClmStatus.Width = 75;
            // 
            // ClmCreator
            // 
            this.ClmCreator.Text = "Creator";
            this.ClmCreator.Width = 84;
            // 
            // ClmSaved
            // 
            this.ClmSaved.Text = "Amount Saved";
            this.ClmSaved.Width = 91;
            // 
            // ClmItems
            // 
            this.ClmItems.Text = "Items";
            this.ClmItems.Width = 162;
            // 
            // BtnGetOrders
            // 
            this.BtnGetOrders.Location = new System.Drawing.Point(242, 129);
            this.BtnGetOrders.Name = "BtnGetOrders";
            this.BtnGetOrders.Size = new System.Drawing.Size(154, 32);
            this.BtnGetOrders.TabIndex = 94;
            this.BtnGetOrders.Text = "GetOrders";
            this.BtnGetOrders.Click += new System.EventHandler(this.BtnGetOrders_Click);
            // 
            // FrmGetOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 517);
            this.Controls.Add(this.LblTimeRange);
            this.Controls.Add(this.CboRole);
            this.Controls.Add(this.LblRole);
            this.Controls.Add(this.CboStatus);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.DatePickStartTo);
            this.Controls.Add(this.DatePickStartFrom);
            this.Controls.Add(this.LblStartSep);
            this.Controls.Add(this.GrpResult);
            this.Controls.Add(this.BtnGetOrders);
            this.Name = "FrmGetOrders";
            this.Text = "FrmGetOrders";
            this.GrpResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblTimeRange;
        private System.Windows.Forms.ComboBox CboRole;
        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.DateTimePicker DatePickStartTo;
        private System.Windows.Forms.DateTimePicker DatePickStartFrom;
        private System.Windows.Forms.Label LblStartSep;
        private System.Windows.Forms.GroupBox GrpResult;
        private System.Windows.Forms.Label LblOrders;
        private System.Windows.Forms.ListView LstOrders;
        private System.Windows.Forms.ColumnHeader ClmOrderId;
        private System.Windows.Forms.ColumnHeader ClmStatus;
        private System.Windows.Forms.ColumnHeader ClmCreator;
        private System.Windows.Forms.ColumnHeader ClmSaved;
        private System.Windows.Forms.ColumnHeader ClmItems;
        private System.Windows.Forms.Button BtnGetOrders;
    }
}