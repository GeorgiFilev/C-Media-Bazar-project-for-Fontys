using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesAppMediaBazaar
{
    class SqlManager
    {
        SqlConnection conn = new SqlConnection();
        private ItemManager manager;
        
        public SqlManager()
        {
            manager = new ItemManager();
        }
        public ItemManager GetItems()
        {
            conn.Open();
            //manager = new ItemManager();
            try
            {
                string sql = $"Select id , type , name , model , quantity from currentstock order by id ;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.SqlConn());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    manager.AddItem(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToInt32(dr[4]));
                }
             
                return manager;
            }
            catch (FieldAccessException ex)
            {
                throw new Exception("Error Loading the items");
            }
            finally
            {
                conn.Close();
            }
         
        }
        public void GetTypes()
        {
            
            conn.Open();
            try
            {
                string sqlType = $"Select type from currentstock group by type ;";
                MySqlCommand cmd = new MySqlCommand(sqlType, conn.SqlConn());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    manager.AddType(Convert.ToString(dr[0]));
                }
        }
            catch
            {
                throw new Exception("Error Loading the types");
    }
            finally
            {
                conn.Close();
            }
        }
        //getting the welcome message
        public string GetName(string email)
        {
            if (GetNameFromDb(email)[1] == "Male")
            {
                return $"Welcome Mr. {GetNameFromDb(email)[0]}";
            }
            else
            {
                return $"Welcome Ms. {GetNameFromDb(email)[0]}";
            }

        }
        public string[] GetNameFromDb(string email)
        {
            List<string> updateList = new List<string>();
            conn.Open();
            string sql = $"Select lname,gender from employees WHERE email = @email;";
            MySqlCommand cmd = new MySqlCommand(sql, conn.SqlConn());
            cmd.Parameters.AddWithValue("@email", email);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                updateList.Add(dr[0].ToString());
                updateList.Add(dr[1].ToString());
            }
            conn.Close();
            return updateList.ToArray();
        }
    }
}
