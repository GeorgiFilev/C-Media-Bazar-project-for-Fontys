using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ManagerAppMediaBazaar
{
    abstract class SQLConnLogin
    {
        SQLConnection sqlcon = new SQLConnection();
        public bool LoginQueries(string email, string password)
        {
            sqlcon.OpenConnection();
            MySqlCommand cmd;
            cmd = new MySqlCommand("SELECT email, password, companyRole from employees WHERE email = @email AND password = @password AND companyRole='Manager';", sqlcon.Mysqlcon);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                sqlcon.CloseConnection();
                return true;
            }
            else
            {
                sqlcon.CloseConnection();
                return false;
            }
        }
    }
}
