using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepotAppMediaBazaar
{
    class SQLConnReshelfRequest
    {
        SQLConnection conn = new SQLConnection();
        MySqlCommand cmd;
        public string[] GetStockReshelfRequestFromDB()
        {
            conn.OpenConnection();
            List<string> reshelfRequests = new List<string>();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from currentstock WHERE requestquantity IS NOT NULL;", conn.Mysqlcon);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                reshelfRequests.Add("#" + dr["id"].ToString() + " " + dr["name"].ToString() + " " + dr["model"].ToString() + " quantity: " + dr["requestquantity"].ToString());
            }
            conn.CloseConnection();
            return reshelfRequests.ToArray();
        }
        public void StockReshelfInDB(string id)
        {
            conn.OpenConnection();
            cmd = new MySqlCommand("UPDATE currentstock SET quantity = quantity - requestquantity, requestquantity = NULL WHERE id = @id;", conn.Mysqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.CloseConnection();
        }
    }
}
