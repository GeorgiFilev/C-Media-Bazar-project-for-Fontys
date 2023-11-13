using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ManagerAppMediaBazaar
{
    class SQLConnectionContracts
    {
        SQLConnection sqlcon = new SQLConnection();
        
        public void UpdateDatabase(string id, int nrOfTerminations,string terminationReason, bool terminationRequest, bool employmentRequest)
        {
            sqlcon.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE employees SET nrOfTerminations=@nrOfTerminations, terminationReason = @terminationReason, terminationRequest = @terminationRequest, employmentRequest = @employmentRequest  WHERE id = @id;", sqlcon.Mysqlcon);
            cmd.Parameters.AddWithValue("@nrOfTerminations", nrOfTerminations);
            cmd.Parameters.AddWithValue("@terminationReason", terminationReason);
            cmd.Parameters.AddWithValue("@terminationRequest", terminationRequest);
            cmd.Parameters.AddWithValue("@employmentRequest", employmentRequest);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            sqlcon.CloseConnection();
        }
        public void DeleteEmployeeDb(string id)
        {
            sqlcon.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM employees WHERE id = @id;", sqlcon.Mysqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            sqlcon.CloseConnection();
        }
        public Employee[] UpdateListEmployees()
        {
            List<Employee> updateList = new List<Employee>();
            sqlcon.OpenConnection();
            string sql = $"Select * from employees order by id ;";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon.Mysqlcon);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                updateList.Add(new Employee(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToInt32(dr[3]), Convert.ToString(dr[4]), Convert.ToString(dr[5]), Convert.ToString(dr[6]), Convert.ToString(dr[7]), Convert.ToString(dr[8]), Convert.ToString(dr[9]), Convert.ToString(dr[10]), Convert.ToString(dr[11]), Convert.ToString(dr[12]), Convert.ToString(dr[13]), Convert.ToString(dr[14]), Convert.ToString(dr[15]), Convert.ToString(dr[16]), Convert.ToString(dr[17]), Convert.ToInt32(dr[18]), Convert.ToString(dr[19]), Convert.ToBoolean(dr[20]), Convert.ToBoolean(dr[21]), Convert.ToString(dr[22]),Convert.ToString(dr[23])));
            }
            sqlcon.CloseConnection();
            return updateList.ToArray();
        }
        public string[] GetNameFromDb(string email)
        {
            List<string> updateList = new List<string>();
            sqlcon.OpenConnection();
            string sql = $"Select lname,gender from employees WHERE email = @email;";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon.Mysqlcon);
            cmd.Parameters.AddWithValue("@email", email);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                updateList.Add(dr[0].ToString());
                updateList.Add(dr[1].ToString());
            }
            sqlcon.CloseConnection();
            return updateList.ToArray();
        }
    }
}
