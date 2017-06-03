using ebay.db;
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
    public partial class FrmGetOrders : Form
    {
        OrderTypeCollection _orders;

        public FrmGetOrders()
        {
            InitializeComponent();


            DateTime now = DateTime.Now;
            DatePickStartTo.Value = now;
            DatePickStartFrom.Value = now.AddDays(-5);


            string[] roles = Enum.GetNames(typeof(TradingRoleCodeType));
            foreach (string rl in roles)
            {
                if (rl != "CustomCode")
                {
                    CboRole.Items.Add(rl);
                }
            }
            CboRole.SelectedIndex = 0;

            string[] statie = Enum.GetNames(typeof(OrderStatusCodeType));
            foreach (string stat in statie)
            {
                if (stat != "CustomCode")
                {
                    CboStatus.Items.Add(stat);
                }
            }
            CboStatus.SelectedIndex = 0;


        }

        private void BtnGetOrders_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("SellingManagerSalesRecordNumber"));
                dt.Columns.Add(new DataColumn("BuyerUserID"));
                dt.Columns.Add(new DataColumn("AmountPaid"));
                dt.Columns.Add(new DataColumn("Timestamp"));
                dt.Columns.Add(new DataColumn("SellerEmail"));
                dt.Columns.Add(new DataColumn("OrderID"));
                dt.Columns.Add(new DataColumn("ClmItems"));

                GetOrdersCall apicall = new GetOrdersCall(Program.GetApiContext());

                TimeFilter fltr = new TimeFilter();

                fltr.TimeFrom = DatePickStartFrom.Value;
                fltr.TimeTo = DatePickStartTo.Value;


                _orders = apicall.GetOrders(fltr, (TradingRoleCodeType)Enum.Parse(typeof(TradingRoleCodeType), CboRole.SelectedItem.ToString()), (OrderStatusCodeType)Enum.Parse(typeof(OrderStatusCodeType), CboStatus.SelectedItem.ToString()));
                if (_orders.Count == 0)
                {

                    MessageBox.Show("There is no order!");
                    return;
                }
                foreach (OrderType order in _orders)
                {
                    //string[] listparams = new string[5];
                    //listparams[0] = order.OrderID;
                    //listparams[1] = order.OrderStatus.ToString();
                    //listparams[2] = order.CreatingUserRole.ToString();
                    //listparams[3] = order.AmountSaved.Value.ToString();
                    string[] itemids = new string[order.TransactionArray.Count];
                    int indx = 0;
                    foreach (TransactionType trans in order.TransactionArray)
                    {
                        itemids[indx] = trans.Item.ItemID;
                        indx++;
                    }
                    //listparams[4] = String.Join(", ", itemids);

                    //ListViewItem vi = new ListViewItem(listparams);
                    //LstOrders.Items.Add(vi);

                    DataRow dr = dt.NewRow();
                    dr["SellingManagerSalesRecordNumber"] = order.ShippingDetails.SellingManagerSalesRecordNumber;
                    dr["BuyerUserID"] = order.BuyerUserID.ToString();
                    dr["AmountPaid"] = order.AmountPaid.ToString();
                    dr["Timestamp"] = apicall.ResponseTime.ToString();
                    dr["SellerEmail"] = order.SellerEmail.ToString();
                    dr["OrderID"] = order.OrderID.ToString();
                    dr["ClmItems"] = String.Join(", ", itemids);
                    dt.Rows.Add(dr);
                }

                this.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_orders != null)
            {
                try
                {

                    new cmd_ebayorder().Import(_orders);
                    MessageBox.Show("Import success!");
                }
                catch
                {

                    MessageBox.Show("Import faile!");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                new cmd_ebayorder().Clear();
                MessageBox.Show("Clear success!");
            }
            catch
            {

                MessageBox.Show("Clear faile!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = null;

            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                row = this.dataGridView1.SelectedRows[0];
            }

            if (this.dataGridView1.SelectedCells.Count != 0)
            {
                row = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex];
            }

            if (row != null)
            {
                GetOrderTransactionsCall apicall = new GetOrderTransactionsCall(Program.GetApiContext());
                StringCollection orderids = new StringCollection(new string[] { row.Cells["OrderID"].Value.ToString() });

                OrderTypeCollection list = apicall.GetOrderTransactions(orderids);
                new FrmXml(apicall.SoapResponse).Show();

            }
            else
                MessageBox.Show("please select one record!");


        }
    }
}
