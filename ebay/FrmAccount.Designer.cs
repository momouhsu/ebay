namespace ebay
{
    partial class FrmAccount
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
            this.GrpProgramAuth = new System.Windows.Forms.GroupBox();
            this.LblDeveloper = new System.Windows.Forms.Label();
            this.LblApplication = new System.Windows.Forms.Label();
            this.TxtApplication = new System.Windows.Forms.TextBox();
            this.TxtDeveloper = new System.Windows.Forms.TextBox();
            this.TxtCertificate = new System.Windows.Forms.TextBox();
            this.LblCertificate = new System.Windows.Forms.Label();
            this.GrpAccountAuth = new System.Windows.Forms.GroupBox();
            this.TxtToken = new System.Windows.Forms.TextBox();
            this.LblToken = new System.Windows.Forms.Label();
            this.GrpUrl = new System.Windows.Forms.GroupBox();
            this.LblEPSUrl = new System.Windows.Forms.Label();
            this.TxtEPSUrl = new System.Windows.Forms.TextBox();
            this.LblSignInUrl = new System.Windows.Forms.Label();
            this.TxtSignInUrl = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboSite = new System.Windows.Forms.ComboBox();
            this.CboLanguage = new System.Windows.Forms.ComboBox();
            this.TxtTimeOut = new System.Windows.Forms.TextBox();
            this.LblTimeOut = new System.Windows.Forms.Label();
            this.LblSite = new System.Windows.Forms.Label();
            this.LblLanguage = new System.Windows.Forms.Label();
            this.TxtVersion = new System.Windows.Forms.TextBox();
            this.LblVersion = new System.Windows.Forms.Label();
            this.GrpFetchToken = new System.Windows.Forms.GroupBox();
            this.txtRulName = new System.Windows.Forms.TextBox();
            this.BtnFetchToken = new System.Windows.Forms.Button();
            this.LblTwo = new System.Windows.Forms.Label();
            this.BtnGenerateSID = new System.Windows.Forms.Button();
            this.LblThree = new System.Windows.Forms.Label();
            this.LblFetch = new System.Windows.Forms.Label();
            this.LblOne = new System.Windows.Forms.Label();
            this.BtnLaunchBrowserWithSecret = new System.Windows.Forms.Button();
            this.TxtSessionID = new System.Windows.Forms.TextBox();
            this.LblSessionID = new System.Windows.Forms.Label();
            this.LblRuInstruct = new System.Windows.Forms.Label();
            this.LblSidLength = new System.Windows.Forms.Label();
            this.GrpProgramAuth.SuspendLayout();
            this.GrpAccountAuth.SuspendLayout();
            this.GrpUrl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GrpFetchToken.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpProgramAuth
            // 
            this.GrpProgramAuth.Controls.Add(this.LblDeveloper);
            this.GrpProgramAuth.Controls.Add(this.LblApplication);
            this.GrpProgramAuth.Controls.Add(this.TxtApplication);
            this.GrpProgramAuth.Controls.Add(this.TxtDeveloper);
            this.GrpProgramAuth.Controls.Add(this.TxtCertificate);
            this.GrpProgramAuth.Controls.Add(this.LblCertificate);
            this.GrpProgramAuth.Location = new System.Drawing.Point(22, 12);
            this.GrpProgramAuth.Name = "GrpProgramAuth";
            this.GrpProgramAuth.Size = new System.Drawing.Size(394, 144);
            this.GrpProgramAuth.TabIndex = 42;
            this.GrpProgramAuth.TabStop = false;
            this.GrpProgramAuth.Text = "API Certificate";
            // 
            // LblDeveloper
            // 
            this.LblDeveloper.Location = new System.Drawing.Point(19, 35);
            this.LblDeveloper.Name = "LblDeveloper";
            this.LblDeveloper.Size = new System.Drawing.Size(135, 26);
            this.LblDeveloper.TabIndex = 18;
            this.LblDeveloper.Text = "Developer:";
            // 
            // LblApplication
            // 
            this.LblApplication.Location = new System.Drawing.Point(19, 68);
            this.LblApplication.Name = "LblApplication";
            this.LblApplication.Size = new System.Drawing.Size(135, 26);
            this.LblApplication.TabIndex = 20;
            this.LblApplication.Text = "Application:";
            // 
            // TxtApplication
            // 
            this.TxtApplication.Location = new System.Drawing.Point(154, 66);
            this.TxtApplication.Name = "TxtApplication";
            this.TxtApplication.Size = new System.Drawing.Size(213, 25);
            this.TxtApplication.TabIndex = 1;
            // 
            // TxtDeveloper
            // 
            this.TxtDeveloper.Location = new System.Drawing.Point(154, 33);
            this.TxtDeveloper.Name = "TxtDeveloper";
            this.TxtDeveloper.Size = new System.Drawing.Size(213, 25);
            this.TxtDeveloper.TabIndex = 0;
            // 
            // TxtCertificate
            // 
            this.TxtCertificate.Location = new System.Drawing.Point(154, 100);
            this.TxtCertificate.Name = "TxtCertificate";
            this.TxtCertificate.PasswordChar = '*';
            this.TxtCertificate.Size = new System.Drawing.Size(213, 25);
            this.TxtCertificate.TabIndex = 2;
            // 
            // LblCertificate
            // 
            this.LblCertificate.Location = new System.Drawing.Point(19, 101);
            this.LblCertificate.Name = "LblCertificate";
            this.LblCertificate.Size = new System.Drawing.Size(135, 26);
            this.LblCertificate.TabIndex = 22;
            this.LblCertificate.Text = "Certificate:";
            // 
            // GrpAccountAuth
            // 
            this.GrpAccountAuth.Controls.Add(this.TxtToken);
            this.GrpAccountAuth.Controls.Add(this.LblToken);
            this.GrpAccountAuth.Location = new System.Drawing.Point(22, 162);
            this.GrpAccountAuth.Name = "GrpAccountAuth";
            this.GrpAccountAuth.Size = new System.Drawing.Size(394, 222);
            this.GrpAccountAuth.TabIndex = 44;
            this.GrpAccountAuth.TabStop = false;
            this.GrpAccountAuth.Text = "eBay Seller Account:";
            // 
            // TxtToken
            // 
            this.TxtToken.Location = new System.Drawing.Point(38, 44);
            this.TxtToken.Multiline = true;
            this.TxtToken.Name = "TxtToken";
            this.TxtToken.Size = new System.Drawing.Size(327, 166);
            this.TxtToken.TabIndex = 45;
            // 
            // LblToken
            // 
            this.LblToken.Location = new System.Drawing.Point(19, 22);
            this.LblToken.Name = "LblToken";
            this.LblToken.Size = new System.Drawing.Size(120, 22);
            this.LblToken.TabIndex = 44;
            this.LblToken.Text = "Token:";
            // 
            // GrpUrl
            // 
            this.GrpUrl.Controls.Add(this.LblEPSUrl);
            this.GrpUrl.Controls.Add(this.TxtEPSUrl);
            this.GrpUrl.Controls.Add(this.LblSignInUrl);
            this.GrpUrl.Controls.Add(this.TxtSignInUrl);
            this.GrpUrl.Controls.Add(this.LblUrl);
            this.GrpUrl.Controls.Add(this.TxtUrl);
            this.GrpUrl.Location = new System.Drawing.Point(22, 404);
            this.GrpUrl.Name = "GrpUrl";
            this.GrpUrl.Size = new System.Drawing.Size(394, 144);
            this.GrpUrl.TabIndex = 45;
            this.GrpUrl.TabStop = false;
            this.GrpUrl.Text = "Urls to make eBay API Call to:";
            // 
            // LblEPSUrl
            // 
            this.LblEPSUrl.Location = new System.Drawing.Point(29, 100);
            this.LblEPSUrl.Name = "LblEPSUrl";
            this.LblEPSUrl.Size = new System.Drawing.Size(125, 26);
            this.LblEPSUrl.TabIndex = 29;
            this.LblEPSUrl.Text = "EPS Url:";
            // 
            // TxtEPSUrl
            // 
            this.TxtEPSUrl.Location = new System.Drawing.Point(154, 100);
            this.TxtEPSUrl.Name = "TxtEPSUrl";
            this.TxtEPSUrl.Size = new System.Drawing.Size(213, 25);
            this.TxtEPSUrl.TabIndex = 28;
            // 
            // LblSignInUrl
            // 
            this.LblSignInUrl.Location = new System.Drawing.Point(29, 66);
            this.LblSignInUrl.Name = "LblSignInUrl";
            this.LblSignInUrl.Size = new System.Drawing.Size(125, 27);
            this.LblSignInUrl.TabIndex = 27;
            this.LblSignInUrl.Text = "Sign-In Url:";
            // 
            // TxtSignInUrl
            // 
            this.TxtSignInUrl.Location = new System.Drawing.Point(154, 66);
            this.TxtSignInUrl.Name = "TxtSignInUrl";
            this.TxtSignInUrl.Size = new System.Drawing.Size(213, 25);
            this.TxtSignInUrl.TabIndex = 26;
            // 
            // LblUrl
            // 
            this.LblUrl.Location = new System.Drawing.Point(29, 33);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(125, 27);
            this.LblUrl.TabIndex = 25;
            this.LblUrl.Text = "API Server Url:";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(154, 33);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(213, 25);
            this.TxtUrl.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboSite);
            this.groupBox1.Controls.Add(this.CboLanguage);
            this.groupBox1.Controls.Add(this.TxtTimeOut);
            this.groupBox1.Controls.Add(this.LblTimeOut);
            this.groupBox1.Controls.Add(this.LblSite);
            this.groupBox1.Controls.Add(this.LblLanguage);
            this.groupBox1.Controls.Add(this.TxtVersion);
            this.groupBox1.Controls.Add(this.LblVersion);
            this.groupBox1.Location = new System.Drawing.Point(443, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 177);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Certificate";
            // 
            // CboSite
            // 
            this.CboSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSite.Location = new System.Drawing.Point(154, 33);
            this.CboSite.Name = "CboSite";
            this.CboSite.Size = new System.Drawing.Size(211, 23);
            this.CboSite.TabIndex = 57;
            // 
            // CboLanguage
            // 
            this.CboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboLanguage.Location = new System.Drawing.Point(154, 66);
            this.CboLanguage.Name = "CboLanguage";
            this.CboLanguage.Size = new System.Drawing.Size(211, 23);
            this.CboLanguage.TabIndex = 56;
            // 
            // TxtTimeOut
            // 
            this.TxtTimeOut.Location = new System.Drawing.Point(154, 133);
            this.TxtTimeOut.Name = "TxtTimeOut";
            this.TxtTimeOut.Size = new System.Drawing.Size(213, 25);
            this.TxtTimeOut.TabIndex = 23;
            // 
            // LblTimeOut
            // 
            this.LblTimeOut.Location = new System.Drawing.Point(19, 133);
            this.LblTimeOut.Name = "LblTimeOut";
            this.LblTimeOut.Size = new System.Drawing.Size(135, 22);
            this.LblTimeOut.TabIndex = 24;
            this.LblTimeOut.Text = "Timeout (ms):";
            // 
            // LblSite
            // 
            this.LblSite.Location = new System.Drawing.Point(19, 33);
            this.LblSite.Name = "LblSite";
            this.LblSite.Size = new System.Drawing.Size(135, 22);
            this.LblSite.TabIndex = 18;
            this.LblSite.Text = "Site:";
            // 
            // LblLanguage
            // 
            this.LblLanguage.Location = new System.Drawing.Point(19, 66);
            this.LblLanguage.Name = "LblLanguage";
            this.LblLanguage.Size = new System.Drawing.Size(135, 23);
            this.LblLanguage.TabIndex = 20;
            this.LblLanguage.Text = "Error Language:";
            // 
            // TxtVersion
            // 
            this.TxtVersion.Location = new System.Drawing.Point(154, 100);
            this.TxtVersion.Name = "TxtVersion";
            this.TxtVersion.Size = new System.Drawing.Size(213, 25);
            this.TxtVersion.TabIndex = 2;
            // 
            // LblVersion
            // 
            this.LblVersion.Location = new System.Drawing.Point(19, 100);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(135, 22);
            this.LblVersion.TabIndex = 22;
            this.LblVersion.Text = "Version:";
            // 
            // GrpFetchToken
            // 
            this.GrpFetchToken.Controls.Add(this.txtRulName);
            this.GrpFetchToken.Controls.Add(this.BtnFetchToken);
            this.GrpFetchToken.Controls.Add(this.LblTwo);
            this.GrpFetchToken.Controls.Add(this.BtnGenerateSID);
            this.GrpFetchToken.Controls.Add(this.LblThree);
            this.GrpFetchToken.Controls.Add(this.LblFetch);
            this.GrpFetchToken.Controls.Add(this.LblOne);
            this.GrpFetchToken.Controls.Add(this.BtnLaunchBrowserWithSecret);
            this.GrpFetchToken.Controls.Add(this.TxtSessionID);
            this.GrpFetchToken.Controls.Add(this.LblSessionID);
            this.GrpFetchToken.Controls.Add(this.LblRuInstruct);
            this.GrpFetchToken.Controls.Add(this.LblSidLength);
            this.GrpFetchToken.Location = new System.Drawing.Point(443, 208);
            this.GrpFetchToken.Name = "GrpFetchToken";
            this.GrpFetchToken.Size = new System.Drawing.Size(403, 321);
            this.GrpFetchToken.TabIndex = 59;
            this.GrpFetchToken.TabStop = false;
            this.GrpFetchToken.Text = "Fetch Token";
            this.GrpFetchToken.Visible = false;
            // 
            // txtRulName
            // 
            this.txtRulName.Location = new System.Drawing.Point(48, 66);
            this.txtRulName.Name = "txtRulName";
            this.txtRulName.Size = new System.Drawing.Size(178, 25);
            this.txtRulName.TabIndex = 73;
            // 
            // BtnFetchToken
            // 
            this.BtnFetchToken.Location = new System.Drawing.Point(134, 277);
            this.BtnFetchToken.Name = "BtnFetchToken";
            this.BtnFetchToken.Size = new System.Drawing.Size(106, 33);
            this.BtnFetchToken.TabIndex = 70;
            this.BtnFetchToken.Text = "Fetch Token";
            // 
            // LblTwo
            // 
            this.LblTwo.Location = new System.Drawing.Point(19, 100);
            this.LblTwo.Name = "LblTwo";
            this.LblTwo.Size = new System.Drawing.Size(25, 22);
            this.LblTwo.TabIndex = 68;
            this.LblTwo.Text = "2)";
            this.LblTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGenerateSID
            // 
            this.BtnGenerateSID.Location = new System.Drawing.Point(298, 166);
            this.BtnGenerateSID.Name = "BtnGenerateSID";
            this.BtnGenerateSID.Size = new System.Drawing.Size(76, 32);
            this.BtnGenerateSID.TabIndex = 61;
            this.BtnGenerateSID.Text = "Retrieve";
            // 
            // LblThree
            // 
            this.LblThree.Location = new System.Drawing.Point(19, 288);
            this.LblThree.Name = "LblThree";
            this.LblThree.Size = new System.Drawing.Size(25, 22);
            this.LblThree.TabIndex = 66;
            this.LblThree.Text = "3)";
            this.LblThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFetch
            // 
            this.LblFetch.Location = new System.Drawing.Point(48, 288);
            this.LblFetch.Name = "LblFetch";
            this.LblFetch.Size = new System.Drawing.Size(48, 22);
            this.LblFetch.TabIndex = 67;
            this.LblFetch.Text = "Click";
            // 
            // LblOne
            // 
            this.LblOne.Location = new System.Drawing.Point(19, 33);
            this.LblOne.Name = "LblOne";
            this.LblOne.Size = new System.Drawing.Size(25, 22);
            this.LblOne.TabIndex = 57;
            this.LblOne.Text = "1)";
            this.LblOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLaunchBrowserWithSecret
            // 
            this.BtnLaunchBrowserWithSecret.Location = new System.Drawing.Point(134, 222);
            this.BtnLaunchBrowserWithSecret.Name = "BtnLaunchBrowserWithSecret";
            this.BtnLaunchBrowserWithSecret.Size = new System.Drawing.Size(106, 31);
            this.BtnLaunchBrowserWithSecret.TabIndex = 65;
            this.BtnLaunchBrowserWithSecret.Text = "Launch Sign-In";
            // 
            // TxtSessionID
            // 
            this.TxtSessionID.Location = new System.Drawing.Point(48, 166);
            this.TxtSessionID.Name = "TxtSessionID";
            this.TxtSessionID.Size = new System.Drawing.Size(178, 25);
            this.TxtSessionID.TabIndex = 59;
            // 
            // LblSessionID
            // 
            this.LblSessionID.Location = new System.Drawing.Point(48, 100);
            this.LblSessionID.Name = "LblSessionID";
            this.LblSessionID.Size = new System.Drawing.Size(312, 55);
            this.LblSessionID.TabIndex = 58;
            this.LblSessionID.Text = "Retrieve the Session ID to be associated with the token to be generated.  And lau" +
    "nch the Sign-In Page.";
            // 
            // LblRuInstruct
            // 
            this.LblRuInstruct.Location = new System.Drawing.Point(48, 33);
            this.LblRuInstruct.Name = "LblRuInstruct";
            this.LblRuInstruct.Size = new System.Drawing.Size(336, 22);
            this.LblRuInstruct.TabIndex = 62;
            this.LblRuInstruct.Text = "Please input an RuName.";
            // 
            // LblSidLength
            // 
            this.LblSidLength.Location = new System.Drawing.Point(240, 177);
            this.LblSidLength.Name = "LblSidLength";
            this.LblSidLength.Size = new System.Drawing.Size(43, 22);
            this.LblSidLength.TabIndex = 60;
            this.LblSidLength.Text = "0";
            this.LblSidLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 681);
            this.Controls.Add(this.GrpFetchToken);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpUrl);
            this.Controls.Add(this.GrpAccountAuth);
            this.Controls.Add(this.GrpProgramAuth);
            this.Name = "FrmAccount";
            this.Text = "FrmAccount";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            this.GrpProgramAuth.ResumeLayout(false);
            this.GrpProgramAuth.PerformLayout();
            this.GrpAccountAuth.ResumeLayout(false);
            this.GrpAccountAuth.PerformLayout();
            this.GrpUrl.ResumeLayout(false);
            this.GrpUrl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpFetchToken.ResumeLayout(false);
            this.GrpFetchToken.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpProgramAuth;
        private System.Windows.Forms.Label LblDeveloper;
        private System.Windows.Forms.Label LblApplication;
        private System.Windows.Forms.TextBox TxtApplication;
        private System.Windows.Forms.TextBox TxtDeveloper;
        private System.Windows.Forms.TextBox TxtCertificate;
        private System.Windows.Forms.Label LblCertificate;
        private System.Windows.Forms.GroupBox GrpAccountAuth;
        private System.Windows.Forms.TextBox TxtToken;
        private System.Windows.Forms.Label LblToken;
        private System.Windows.Forms.GroupBox GrpUrl;
        private System.Windows.Forms.Label LblEPSUrl;
        private System.Windows.Forms.TextBox TxtEPSUrl;
        private System.Windows.Forms.Label LblSignInUrl;
        private System.Windows.Forms.TextBox TxtSignInUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboSite;
        private System.Windows.Forms.ComboBox CboLanguage;
        private System.Windows.Forms.TextBox TxtTimeOut;
        private System.Windows.Forms.Label LblTimeOut;
        private System.Windows.Forms.Label LblSite;
        private System.Windows.Forms.Label LblLanguage;
        private System.Windows.Forms.TextBox TxtVersion;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.GroupBox GrpFetchToken;
        private System.Windows.Forms.TextBox txtRulName;
        private System.Windows.Forms.Button BtnFetchToken;
        internal System.Windows.Forms.Label LblTwo;
        internal System.Windows.Forms.Button BtnGenerateSID;
        internal System.Windows.Forms.Label LblThree;
        internal System.Windows.Forms.Label LblFetch;
        internal System.Windows.Forms.Label LblOne;
        internal System.Windows.Forms.Button BtnLaunchBrowserWithSecret;
        internal System.Windows.Forms.TextBox TxtSessionID;
        internal System.Windows.Forms.Label LblSessionID;
        internal System.Windows.Forms.Label LblRuInstruct;
        internal System.Windows.Forms.Label LblSidLength;
    }
}