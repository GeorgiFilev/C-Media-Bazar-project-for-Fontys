using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesAppMediaBazaar
{
    class SqlRequestSend
    {
        SqlConnection conn = new SqlConnection();

        public void SendRequest(int id, int quantity)
        {
            conn.Open();
            try
            {
                string sql = "update currentstock set requestquantity = @quantity where id = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.SqlConn());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.ExecuteNonQuery();
            }
            catch (ExecutionEngineException ex)
            {
                throw new Exception("the request was not sent");
            }
            finally
            {
                conn.Close();
            }
           
        }

    }
}
