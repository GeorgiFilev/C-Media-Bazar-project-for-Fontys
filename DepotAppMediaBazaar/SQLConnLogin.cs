using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepotAppMediaBazaar
{
    class SQLConnLogin
    {
        SQLConnection conn = new SQLConnection();
        public bool LoginQueries(string email, string password)
        {
            conn.OpenConnection();
            MySqlCommand cmd;
            cmd = new MySqlCommand("SELECT email, password, companyRole from employees WHERE email = @email AND password = @password AND companyRole='Depot';", conn.Mysqlcon);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                conn.CloseConnection();
                return true;
            }
            else
            {
                conn.CloseConnection();
                return false;
            }
        }
    }
}
