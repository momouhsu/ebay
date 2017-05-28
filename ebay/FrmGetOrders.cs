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
                dt.Columns.Add(new DataColumn("ClmOrderId"));
                dt.Columns.Add(new DataColumn("ClmStatus"));
                dt.Columns.Add(new DataColumn("ClmCreator"));
                dt.Columns.Add(new DataColumn("ClmItems"));

                GetOrdersCall apicall = new GetOrdersCall(Program.GetApiContext());

                TimeFilter fltr = new TimeFilter();

                fltr.TimeFrom = DatePickStartFrom.Value;
                fltr.TimeTo = DatePickStartTo.Value;


                OrderTypeCollection orders = apicall.GetOrders(fltr, (TradingRoleCodeType)Enum.Parse(typeof(TradingRoleCodeType), CboRole.SelectedItem.ToString()), (OrderStatusCodeType)Enum.Parse(typeof(OrderStatusCodeType), CboStatus.SelectedItem.ToString()));
                if (orders.Count == 0)
                {

                    MessageBox.Show("There is no order!");
                    return;
                }
                foreach (OrderType order in orders)
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
                    dr["ClmOrderId"] = order.OrderID;
                    dr["ClmStatus"] = order.OrderStatus.ToString();
                    dr["ClmCreator"] = order.CreatingUserRole.ToString();
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
    }
}
