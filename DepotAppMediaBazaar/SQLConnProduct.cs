using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DepotAppMediaBazaar
{
    class SQLConnProduct
    {
        MySqlCommand cmd;
        SQLConnection conn = new SQLConnection();
      

        public void AddProductToDB(ProductType type, string name, string model, int quantity, string department)
        {
            conn.OpenConnection();
            cmd = new MySqlCommand("INSERT INTO currentstock (type, name, model, quantity, department, stagingarea) VALUES( @type, @name, @model, @quantity, @department, @stagingarea);", conn.Mysqlcon);
            cmd.Parameters.AddWithValue("@type", type.ToString());
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@department", department);
            cmd.Parameters.AddWithValue("@stagingarea", 0);
            cmd.ExecuteNonQuery();
            conn.CloseConnection();
        }
        
        public void InsertIntoCurrentStockDB(string id)
        {
            conn.OpenConnection();
            cmd = new MySqlCommand("UPDATE currentstock SET stagingarea = 1 WHERE id = @id", conn.Mysqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.CloseConnection();
        }
        public void UpdateProductInformationDB(string id, string type, string model, string name, int quantity, string department)
        {
            conn.OpenConnection();
            cmd = new MySqlCommand("UPDATE currentstock SET type = @type, model = @model, name = @name, quantity = @quantity, department = @department  WHERE id = @id;", conn.Mysqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@department", department);
            cmd.ExecuteNonQuery();
            conn.CloseConnection();
        }

        public Product[] GetPendingProductsInfoFromDB()
        {
            List<Product> products = new List<Product>();
            conn.OpenConnection();  
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM currentstock WHERE stagingarea = 0;", conn.Mysqlcon);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                products.Add(new Product(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToInt32(dr[4]), dr[5].ToString()));
            }
            conn.CloseConnection();
            return products.ToArray();
           
        }
        public Product[] GetCurrentProductsInfoFromDB()
        {
            List<Product> products = new List<Product>();
            conn.OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from currentstock  WHERE stagingarea = 1;", conn.Mysqlcon);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                products.Add(new Product(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToInt32(dr[4]), dr[5].ToString()));
            }
            conn.CloseConnection();
            return products.ToArray();
        }
        public string[] UpdateListDepartments()
        {
            List<string> updateList = new List<string>();
            conn.OpenConnection();
            string sql = $"SELECT DISTINCT department FROM departments WHERE department LIKE 'Sales%';";
            MySqlCommand cmd = new MySqlCommand(sql, conn.Mysqlcon);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                updateList.Add(dr[0].ToString());
            }
            conn.CloseConnection();
            return updateList.ToArray();

        }
        public string[] GetNameFromDb(string email)
        {
            List<string> updateList = new List<string>();
            conn.OpenConnection();
            string sql = $"Select lname,gender from employees WHERE email = @email;";
            MySqlCommand cmd = new MySqlCommand(sql, conn.Mysqlcon);
            cmd.Parameters.AddWithValue("@email", email);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                updateList.Add(dr[0].ToString());
                updateList.Add(dr[1].ToString());
            }
            conn.CloseConnection();
            return updateList.ToArray();
        }

    }
}
