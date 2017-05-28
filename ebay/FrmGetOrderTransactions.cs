using eBay.Service.Call;
using eBay.Service.Core.Soap;
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
    public partial class FrmGetOrderTransactions : Form
    {
        public FrmGetOrderTransactions()
        {
            InitializeComponent();
        }

        private void BtnGetOrders_Click(object sender, EventArgs e)
        {

            GetOrderTransactionsCall apicall = new GetOrderTransactionsCall(Program.GetApiContext());
            
        }
    }
}
