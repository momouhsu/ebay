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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClmOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblOrders = new System.Windows.Forms.Label();
            this.BtnGetOrders = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GrpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.GrpResult.Controls.Add(this.dataGridView1);
            this.GrpResult.Controls.Add(this.LblOrders);
            this.GrpResult.Location = new System.Drawing.Point(22, 173);
            this.GrpResult.Name = "GrpResult";
            this.GrpResult.Size = new System.Drawing.Size(652, 321);
            this.GrpResult.TabIndex = 95;
            this.GrpResult.TabStop = false;
            this.GrpResult.Text = "Result";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmOrderId,
            this.ClmStatus,
            this.ClmCreator,
            this.ClmItems});
            this.dataGridView1.Location = new System.Drawing.Point(13, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(620, 246);
            this.dataGridView1.TabIndex = 13;
            // 
            // ClmOrderId
            // 
            this.ClmOrderId.DataPropertyName = "ClmOrderId";
            this.ClmOrderId.HeaderText = "Order Id";
            this.ClmOrderId.Name = "ClmOrderId";
            // 
            // ClmStatus
            // 
            this.ClmStatus.DataPropertyName = "ClmStatus";
            this.ClmStatus.HeaderText = "Status";
            this.ClmStatus.Name = "ClmStatus";
            // 
            // ClmCreator
            // 
            this.ClmCreator.DataPropertyName = "ClmCreator";
            this.ClmCreator.HeaderText = "Creator";
            this.ClmCreator.Name = "ClmCreator";
            // 
            // ClmItems
            // 
            this.ClmItems.DataPropertyName = "ClmItems";
            this.ClmItems.HeaderText = "Items";
            this.ClmItems.Name = "ClmItems";
            // 
            // LblOrders
            // 
            this.LblOrders.Location = new System.Drawing.Point(10, 33);
            this.LblOrders.Name = "LblOrders";
            this.LblOrders.Size = new System.Drawing.Size(134, 32);
            this.LblOrders.TabIndex = 12;
            this.LblOrders.Text = "Orders:";
            // 
            // BtnGetOrders
            // 
            this.BtnGetOrders.Location = new System.Drawing.Point(127, 135);
            this.BtnGetOrders.Name = "BtnGetOrders";
            this.BtnGetOrders.Size = new System.Drawing.Size(154, 32);
            this.BtnGetOrders.TabIndex = 94;
            this.BtnGetOrders.Text = "GetOrders";
            this.BtnGetOrders.Click += new System.EventHandler(this.BtnGetOrders_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 32);
            this.button1.TabIndex = 104;
            this.button1.Text = "Import";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 32);
            this.button2.TabIndex = 105;
            this.button2.Text = "Clear DB";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmGetOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 751);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button BtnGetOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}