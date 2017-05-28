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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmGetOrders().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmGetItemTransactions().Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmGetOrderTransactions().Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            new FrmAccount().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FrmGetMyMessagesCall().Show();
            
        }
    }
}
