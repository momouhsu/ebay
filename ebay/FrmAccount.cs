using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebay
{
    public partial class FrmAccount : Form
    {
        public FrmAccount()
        {
            InitializeComponent();
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            this.TxtDeveloper.Text = Program.GetApiContext().ApiCredential.ApiAccount.Developer;
            this.TxtApplication.Text = Program.GetApiContext().ApiCredential.ApiAccount.Application;
            this.TxtCertificate.Text = Program.GetApiContext().ApiCredential.ApiAccount.Certificate;
            this.TxtToken.Text = Program.GetApiContext().ApiCredential.eBayToken;

            this.TxtUrl.Text = Program.GetApiContext().SoapApiServerUrl;
            this.TxtSignInUrl.Text = Program.GetApiContext().SignInUrl;
            this.TxtEPSUrl.Text = Program.GetApiContext().EPSServerUrl;


            this.TxtVersion.Text = Program.GetApiContext().Version;
            this.TxtTimeOut.Text = Program.GetApiContext().Timeout.ToString();
            this.txtRulName.Text = Program.GetApiContext().RuleName;
             


        }
    }
}
