using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockAppMediaBazaar
{
    class SqlConnEmployee
    {
        SQLConnection sqlMain=new SQLConnection();
        MySqlCommand cmd = new MySqlCommand();
        
        public void EmployeeQuery(string firstName, string lastName, int age, string gender, string email, string phone, string birthplace, string birthday, string city, string zip, string address, string securityNumber, string nationality, double fte, string hiredDate, string preferredWorkDays, string preferredShifts,bool employmentRequest,string companyRole)
        {
           sqlMain.OpenConnection();
            cmd = new MySqlCommand("Insert into employees (fname,lname,age,gender,email,phone,bplace,bday,city,zip,address,snumber,nationality,fte,hdate,wdays,wshifts,employmentRequest,companyRole)" +
                                 " VALUES(@fname, @lname, @age, @gender, @email, @phone, @bplace, @bday, @city, @zip, @address, @snumber, @nationality, @fte, @hdate, @wdays,@wshifts,@employmentRequest,@companyRole)", sqlMain.SqlConn());


            cmd.Parameters.AddWithValue("@fname", firstName);
            cmd.Parameters.AddWithValue("@lname", lastName);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@bplace", birthplace);
            cmd.Parameters.AddWithValue("@bday", birthday);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@zip", zip);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@snumber", securityNumber);
            cmd.Parameters.AddWithValue("@nationality", nationality);
            cmd.Parameters.AddWithValue("@fte", fte);
            cmd.Parameters.AddWithValue("@hdate", hiredDate);
            cmd.Parameters.AddWithValue("@wdays", preferredWorkDays);
            cmd.Parameters.AddWithValue("@wshifts", preferredShifts);
            cmd.Parameters.AddWithValue("@employmentRequest", employmentRequest);
            cmd.Parameters.AddWithValue("@companyRole", companyRole);
            cmd.ExecuteNonQuery();
            sqlMain.CloseConnection();
        }
        //EMPLOYEE DETAILS CLASS
       
        
       
        //Update employee information
        public void UpdateEmployeeInformation(string id, string firstName, string lastName, int age, string gender, string email, string phone, string birthplace, string birthday, string city, string zip, string address, string securityNumber, string nationality, double fte, string hiredDate, string preferredWorkDays, string preferredShifts,string companyRole)
        {
            sqlMain.OpenConnection();
            cmd = new MySqlCommand("UPDATE employees SET fname = @fname, lname = @lname, age = @age, gender = @gender, email = @email, phone = @phone, bplace = @bplace, bday = @bday, city = @city, zip = @zip, address = @address, snumber = @snumber, nationality = @nationality, fte = @fte, hdate = @hdate, wdays = @wdays, wshifts=@wshifts, companyRole = @companyRole  WHERE id = @id;", sqlMain.SqlConn());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fname", firstName);
            cmd.Parameters.AddWithValue("@lname", lastName);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@bplace", birthplace);
            cmd.Parameters.AddWithValue("@bday", birthday);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@zip", zip);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@snumber", securityNumber);
            cmd.Parameters.AddWithValue("@nationality", nationality);
            cmd.Parameters.AddWithValue("@fte", fte);
            cmd.Parameters.AddWithValue("@hdate", hiredDate);
            cmd.Parameters.AddWithValue("@wdays", preferredWorkDays);
            cmd.Parameters.AddWithValue("@wshifts", preferredShifts);
            cmd.Parameters.AddWithValue("@companyRole", companyRole);
            cmd.ExecuteNonQuery();
           sqlMain.CloseConnection();
        }

        //get details  from database
        public Employee[] UpdateEmployeesFromDb()
        {
         
            List<Employee> listEmployeesDb = new List<Employee>();
            sqlMain.OpenConnection();

            string sql = $"Select * from employees order by id ;";
            MySqlCommand cmd = new MySqlCommand(sql, sqlMain.SqlConn());
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listEmployeesDb.Add(new Employee(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToInt32(dr[3]), Convert.ToString(dr[4]), Convert.ToString(dr[5]), Convert.ToString(dr[6]), Convert.ToString(dr[7]), Convert.ToString(dr[8]), Convert.ToString(dr[9]), Convert.ToString(dr[10]), Convert.ToString(dr[11]), Convert.ToString(dr[12]), Convert.ToString(dr[13]), Convert.ToDouble(dr[14]), Convert.ToString(dr[15]), Convert.ToString(dr[16]), Convert.ToString(dr[17]), Convert.ToInt32(dr[18]), Convert.ToString(dr[19]), Convert.ToBoolean(dr[20]), Convert.ToBoolean(dr[21]),Convert.ToString(dr[22])));
               
            }

            return listEmployeesDb.ToArray();

        }

       
        public MySqlDataReader ShowDetailsUpdate(string id, TextBox t0, TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6, TextBox t7, TextBox t8,
            TextBox t9, TextBox t10, TextBox t11, TextBox t12, TextBox t13, TextBox t14, TextBox t15)
        {
           sqlMain.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM employeeshire WHERE id = @id ;", sqlMain.SqlConn());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                t0.Text = dr.GetValue(1).ToString();
                t1.Text = dr.GetValue(2).ToString();
                t2.Text = dr.GetValue(3).ToString();
                t3.Text = dr.GetValue(4).ToString();
                t4.Text = dr.GetValue(5).ToString();
                t5.Text = dr.GetValue(6).ToString();
                t6.Text = dr.GetValue(7).ToString();
                t7.Text = dr.GetValue(8).ToString();
                t8.Text = dr.GetValue(9).ToString();
                t9.Text = dr.GetValue(10).ToString();
                t10.Text = dr.GetValue(11).ToString();
                t11.Text = dr.GetValue(12).ToString();
                t12.Text = dr.GetValue(13).ToString();
                t13.Text = dr.GetValue(15).ToString();
                t14.Text = dr.GetValue(16).ToString();
                t15.Text = dr.GetValue(17).ToString();
            }
            return dr;
        }
        public string[] UpdateListDepartments()
        {
            List<string> updateList = new List<string>();
            sqlMain.OpenConnection();
            string sql = $"SELECT DISTINCT department FROM departments;";
            MySqlCommand cmd = new MySqlCommand(sql, sqlMain.SqlConn());
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                updateList.Add(dr[0].ToString());
            }
            sqlMain.CloseConnection();
            return updateList.ToArray();
        }
    }
}
