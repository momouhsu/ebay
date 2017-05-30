using ebay.ds;
using eBay.Service.Core.Soap;
using MySql.Data.MySqlClient;
using System;

namespace ebay.db
{
    public class cmd_ebayorder : cmd_ebay
    {
        public void Clear()
        {
            ConnTransHandle((MySqlConnection conn, MySqlTransaction trans) =>
            {
                base.ExecuteNonQuery("delete from ebayorder", null, conn, trans);
                base.ExecuteNonQuery("delete from ebayorder_details", null, conn, trans);

            });
        }

        public void Import(OrderTypeCollection orders)
        {

            string insert_ebayorder = string.Format(insertTemplate,
                "ebayorder",
                GetColumnsSql(new ds_ebayorder().ebayorder),
                GetColumnsParamSql(new ds_ebayorder().ebayorder));
            string insert_ebayorder_details = string.Format(insertTemplate,
                "ebayorder_details",
                GetColumnsSql(new ds_ebayorder().ebayorder_details),
                GetColumnsParamSql(new ds_ebayorder().ebayorder_details));

            ConnTransHandle((MySqlConnection conn, MySqlTransaction trans) =>
            {
                foreach (OrderType order in orders)
                {
                    MySqlParameter[] ps = new MySqlParameter[] {

                        new MySqlParameter("OrderID", order.OrderID),
                        new MySqlParameter("OrderStatus", order.OrderStatus),
                        new MySqlParameter("AmountPaid", order.AmountPaid),
                        new MySqlParameter("SellingManagerSalesRecordNumber", order.ShippingDetails.SellingManagerSalesRecordNumber),
                        new MySqlParameter("SellerEmail", order.SellerEmail),
                        new MySqlParameter("SellerUserID", order.SellerUserID)
                    };

                    base.ExecuteNonQuery(insert_ebayorder, ps, conn, trans);

                    foreach (TransactionType line in order.TransactionArray)
                    {
                        MySqlParameter[] psline = new MySqlParameter[] {
                            new MySqlParameter("OrderID", order.OrderID),
                            new MySqlParameter("ItemID", line.Item.ItemID),
                            new MySqlParameter("SKU", line.Item.SKU),
                            new MySqlParameter("QuantityPurchased", line.QuantityPurchased)
                        };
                        base.ExecuteNonQuery(insert_ebayorder_details, psline, conn, trans);
                    }

                }

                int s = Convert.ToInt16("s");

            });

        }

        public void Delete()
        {

        }



    }
}
