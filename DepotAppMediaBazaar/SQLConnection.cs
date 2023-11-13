using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;
using System.Windows.Forms;

namespace DepotAppMediaBazaar
{
    class SQLConnection
    {
            private static string connectionString = "Server=studmysql01.fhict.local;Uid=dbi432557;Database=dbi432557;Pwd=vedsalta;";
            MySqlConnection mysqlcon = new MySqlConnection(connectionString);
            public MySqlConnection Mysqlcon { get { return this.mysqlcon; } }
            public void OpenConnection()
            {
                mysqlcon.Open();
            }
            public void CloseConnection()
            {
                mysqlcon.Close();
            }
      
       
       
        public void ViewStockReshelfRequests(ListBox employeelist)
        {
            //OpenConnection();
            //DataTable dt = new DataTable();
            //MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from currentstock WHERE requestquantity IS NOT NULL;", ConnectionString);
            //da.Fill(dt);
            //employeelist.Items.Clear();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    employeelist.Items.Add(dr["id"].ToString() + " " + dr["name"].ToString() + " " + dr["model"].ToString() + " " + dr["requestquantity"].ToString());
            //}
            //CloseConnection();
        }
        public void StockReshelf(string id)
        {
        //    OpenConnection();
        //    cmd = new MySqlCommand("UPDATE currentstock SET quantity = quantity - requestquantity, requestquantity = NULL WHERE id = @id;", sqlcon);
        //    cmd.Parameters.AddWithValue("@id", id);
        //    cmd.ExecuteNonQuery();
        //    CloseConnection();
        }

    }
}

    
