using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace ebay.db
{
    public abstract class cmd_ebay
    {
        protected const string insertTemplate = "insert into {0} ({1}) values({2})";

        protected string GetColumnsSql(DataTable dt)
        {

            return string.Join(",", GetColumnNames(dt));
        }

        protected string GetColumnsParamSql(DataTable dt)
        {

            return "@" + string.Join(",@", GetColumnNames(dt));
        }

        string[] GetColumnNames(DataTable dt)
        {
            List<String> result = new List<string>();
            foreach (DataColumn dc in dt.Columns)
            {
                result.Add(dc.ColumnName);
            }
            return result.ToArray();
        }

        private static string connString = "";
        public static string GetConnString()
        {
            if (connString == "")
            {
                connString = System.Configuration.ConfigurationManager.ConnectionStrings["itcfaxco_ebay"].ConnectionString;
            }
            return connString;
        }

        protected void ConnHandle(Action<MySqlConnection> action)
        {
            using (MySqlConnection conn = new MySqlConnection(GetConnString()))
            {
                conn.Open();
                action(conn);
                conn.Close();
            }
        }

        protected void ConnTransHandle(Action<MySqlConnection, MySqlTransaction> action)
        {

            ConnHandle((MySqlConnection conn) =>
            {
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    action(conn, trans);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
                finally
                {

                    conn.Close();
                }

            });
        }

        protected DataSet Query(string sql, MySqlParameter[] ps, MySqlConnection conn)
        {
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
            foreach (MySqlParameter p in ps)
            {
                adp.SelectCommand.Parameters.Add(p);
            }
            DataSet result = new DataSet();
            adp.Fill(result);
            return result;
        }

        protected int ExecuteNonQuery(string sql, MySqlParameter[] ps, MySqlConnection conn, MySqlTransaction transaction = null)
        {
            MySqlCommand comm = new MySqlCommand(sql, conn, transaction);
            if (ps != null)
                foreach (MySqlParameter p in ps)
                {
                    comm.Parameters.Add(p);
                }
            return comm.ExecuteNonQuery();
        }



    }
}
