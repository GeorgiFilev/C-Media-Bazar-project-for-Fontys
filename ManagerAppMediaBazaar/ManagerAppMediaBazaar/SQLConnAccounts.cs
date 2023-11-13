
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAppMediaBazaar
{
    class SQLConnAccounts
    {
        SQLConnection sqlcon = new SQLConnection();

        public void UpdateDatabase(int id, string username, string password, string role)
        {
            sqlcon.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE employees SET email=@username, password = @pass, companyRole = @role  WHERE id = @id;", sqlcon.Mysqlcon);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            sqlcon.CloseConnection();
        }
        public void UpdateDatabaseDepartments(string newName,string name, int availability)
        {
            sqlcon.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE departments SET department=@newName, availability = @availability  WHERE department = @name;", sqlcon.Mysqlcon);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@newName", newName);
            cmd.Parameters.AddWithValue("@availability", availability);
            cmd.ExecuteNonQuery();
            sqlcon.CloseConnection();
        }
        public void AddDatabaseDepartments(string name, int availability)
        {
            sqlcon.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO departments (department,availability) VALUES (@name, @availability);", sqlcon.Mysqlcon);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@availability", availability);
            cmd.ExecuteNonQuery();
            sqlcon.CloseConnection();
        }
        public string[] UpdateListDepartments()
        {
            List<string> updateList = new List<string>();
            sqlcon.OpenConnection();
            string sql = $"SELECT DISTINCT department FROM departments WHERE availability = 1;";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon.Mysqlcon);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                updateList.Add(dr[0].ToString());
            }
            sqlcon.CloseConnection();
            return updateList.ToArray();
        }
        public string[] UpdateListDeletedDepartments()
        {
            List<string> updateList = new List<string>();
            sqlcon.OpenConnection();
            string sql = $"SELECT DISTINCT department FROM departments WHERE availability = 0;";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon.Mysqlcon);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                updateList.Add(dr[0].ToString());
            }
            sqlcon.CloseConnection();
            return updateList.ToArray();
        }
        //public void AddToDatabase(int id, string username, string password, string role)
        //{
        //    sqlcon.OpenConnection();
        //    MySqlCommand cmd = new MySqlCommand("INSERT INTO  accounts (id,username, password, role) VALUES (@id, @username, @pass, @role);", sqlcon.Mysqlcon);
        //    cmd.Parameters.AddWithValue("@username", username);
        //    cmd.Parameters.AddWithValue("@pass", password);
        //    cmd.Parameters.AddWithValue("@role", role);
        //    cmd.Parameters.AddWithValue("@id", id);
        //    cmd.ExecuteNonQuery();
        //    sqlcon.CloseConnection();
        //}
        //public void AccountCreated(int id)
        //{
        //    sqlcon.OpenConnection();
        //    MySqlCommand cmd = new MySqlCommand("UPDATE employees SET account = true  WHERE id = @id;", sqlcon.Mysqlcon);
        //    cmd.Parameters.AddWithValue("@id", id);
        //    cmd.ExecuteNonQuery();
        //    sqlcon.CloseConnection();
        //}
    }
}
