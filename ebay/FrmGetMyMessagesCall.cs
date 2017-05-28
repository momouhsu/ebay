using eBay.Service.Call;
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
    public partial class FrmGetMyMessagesCall : Form
    {
        public FrmGetMyMessagesCall()
        {
            InitializeComponent();
        }

        private void FrmGetMyMessagesCall_Load(object sender, EventArgs e)
        {

        }

        private void BtnGetMessage_Click(object sender, EventArgs e)
        {
            GetMyMessagesCall apicall = new GetMyMessagesCall(Program.GetApiContext()); 

            //OrderTypeCollection list = apicall.GetMyMessages(orderids);
            //if (list.Count == 0)
            //{

            //    MessageBox.Show("There is no order!");
            //    return;
            //}

            TxtXml.Text = apicall.SoapResponse;
        }
    }
}
