using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StockAppMediaBazaar
{
    class SqlConnLogin
    {

        SQLConnection sqlMain= new SQLConnection(); 
        MySqlCommand cmd = new MySqlCommand();
        public bool LoginQueries(string email, string password)
        {
            sqlMain.OpenConnection();

            cmd = new MySqlCommand("SELECT email, password, companyRole from employees WHERE email = @email AND password = @password AND companyRole='HR';",sqlMain.SqlConn());
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();



            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
               sqlMain.CloseConnection();

                return true;
            }
            else
            {
                sqlMain.CloseConnection();
                return false;
            }

           
        }
    }
}
