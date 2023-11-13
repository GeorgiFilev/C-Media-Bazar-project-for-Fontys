using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesAppMediaBazaar
{
    class SqlLogin
    {
        SqlConnection conn = new SqlConnection();

        public bool LoginCheck(string username, string password)
        {
            conn.Open();
            try
            {
                string Sql = "SELECT email, password, companyRole from employees WHERE email = @email AND password = @password AND companyRole = 'Sales' OR companyRole = 'Sales1stFloor' OR companyRole = 'Sales2ndFloor' OR companyRole = 'Sales3rdFloor'; ";
                MySqlCommand cmd = new MySqlCommand(Sql, conn.SqlConn());
                cmd.Parameters.AddWithValue("@email", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
