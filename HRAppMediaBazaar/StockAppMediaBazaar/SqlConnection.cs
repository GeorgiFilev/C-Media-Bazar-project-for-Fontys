using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data;

namespace StockAppMediaBazaar
{
    class SQLConnection
    {
        MySqlConnection sqlcon ;
       

        private MySqlCommand cmd;
        string connectionString= "Server=studmysql01.fhict.local;Uid=dbi432557;Database=dbi432557;Pwd=vedsalta;";

        public string ConnectionString
        {
            get
            {
                return this.connectionString;
            } 
        }
        public MySqlConnection SqlConn()
        {
            return this.sqlcon;
        }

        public void OpenConnection()
        {
            sqlcon = new MySqlConnection(connectionString);
            sqlcon.Open();
        }

        public void CloseConnection()
        {
            sqlcon.Close();
        }
        //LOGIN CLASS
        public void LoginQuery(string query,string username,string password)
        {
            cmd = new MySqlCommand(query,sqlcon);
           
            cmd.Parameters.AddWithValue("@userid", username);
            cmd.Parameters.AddWithValue("@password", password);



            cmd.ExecuteNonQuery();
        }

       
        //HIRE EMPLOYEE CLASS
        public void EmployeeQuery(string firstName, string lastName, int age, string gender, string email, string phone, string birthplace, string birthday, string city, int zip, string address, int securityNumber, string nationality, string fte, string hiredDate, string preferredWorkDays,string preferredShifts)
        {
            OpenConnection();
            cmd=new MySqlCommand("Insert into employmentrequest (fname,lname,age,gender,email,phone,bplace,bday,city,zip,address,snumber,nationality,fte,hdate,wdays,wshifts)" +
                                 " VALUES(@fname, @lname, @age, @gender, @email, @phone, @bplace, @bday, @city, @zip, @address, @snumber, @nationality, @fte, @hdate, @wdays,@wshifts)", sqlcon);

            
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
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        //EMPLOYEE DETAILS CLASS
        public void ViewEmployeeInListBox(ListBox employeelist)
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from employeeshire;", ConnectionString);
            da.Fill(dt);
            employeelist.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                employeelist.Items.Add(dr["id"].ToString() + " " + dr["fname"].ToString() + " " + dr["lname"].ToString());
            }

        }
       public void SearchEmployeeInListBox(ListBox employeelist,string text)
        {
           OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from employeeshire WHERE fname LIKE '%" + text + "%' OR lname LIKE '%"+ text +"%'  OR id LIKE '%"+text+"%' OR concat(fname , ' ' , lname) LIKE '%"+ text +"%'; ", ConnectionString);
            da.SelectCommand.Parameters.AddWithValue("@text", text); //To be tested!!!!!!!!!
            da.Fill(dt);
            employeelist.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                employeelist.Items.Add( dr["id"] + " " + dr["fname"].ToString() + " " + dr["lname"].ToString());
            }
            CloseConnection();
        }

        public MySqlDataReader ShowDetails(string id,Label l0,Label l1,Label l2,Label l3,Label l4,Label l5,Label l6,Label l7,Label l8,
            Label l9,Label l10,Label l11,Label l12,Label l13,Label l135,Label l14,Label l15)
        {
            OpenConnection();
            MySqlCommand cmd=new MySqlCommand("SELECT * FROM employeeshire WHERE id = @id ;",sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                l0.Text = dr.GetValue(0).ToString();
                l1.Text = dr.GetValue(1).ToString();
                l2.Text = dr.GetValue(2).ToString();
                l3.Text = dr.GetValue(3).ToString();
                l4.Text = dr.GetValue(4).ToString();
                l5.Text = dr.GetValue(5).ToString();
                l6.Text = dr.GetValue(6).ToString();
                l7.Text = dr.GetValue(7).ToString();
                l8.Text = dr.GetValue(8).ToString();
                l9.Text = dr.GetValue(9).ToString();
                l10.Text = dr.GetValue(10).ToString();
                l11.Text = dr.GetValue(11).ToString();
                l12.Text = dr.GetValue(12).ToString();
                l13.Text = dr.GetValue(13).ToString();
                l135.Text = dr.GetValue(14).ToString();
                l14.Text = dr.GetValue(15).ToString();
                l15.Text = dr.GetValue(16).ToString();
            }
            return dr;
        }
        // SHIFT CLASS
        public void AddShift(string id, string day,string shift,string week)
        {
            OpenConnection();
            cmd = new MySqlCommand("Insert into shifts (id,fname,lname,day,shift,week) SELECT id,fname,lname,@day,@shift,@week FROM employeeshire WHERE id = @id" , sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@shift", shift);
            cmd.Parameters.AddWithValue("@week", week);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void DeleteAllShifts()
        {
            OpenConnection();
            cmd = new MySqlCommand("DELETE FROM shifts", sqlcon);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void ViewShiftsInListBox(ListBox lbShifts)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from shifts;", ConnectionString);
            da.Fill(dt);
            lbShifts.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                lbShifts.Items.Add(dr["id"].ToString() + " " + dr["fname"].ToString() + " " + dr["lname"].ToString() + " " + dr["day"].ToString() + " " + dr["shift"].ToString() + " " + dr["week"].ToString());
            }
            CloseConnection();
        }
        public MySqlDataReader GetPreferredDays(string id,Label day)
        {
            OpenConnection();
            cmd = new MySqlCommand("SELECT * from employeeshire WHERE  id = @id;", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                day.Text = dr.GetValue(16).ToString();
            }
            return dr;
        }
        public MySqlDataReader GetPreferredShift(string id,ComboBox cbx)
        {
            OpenConnection();
            cmd = new MySqlCommand("SELECT * from employeeshire WHERE  id = @id;", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbx.Text = dr.GetValue(17).ToString();
            }
            return dr;
        }
        //TERMINATION REQUEST
        public void SendTerminationRequest(string id)
        {
            OpenConnection();
            cmd = new MySqlCommand("UPDATE employeeshire SET terminationrequest = 1 WHERE id = @id;", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void SendTerminationReason(string id, string reason)
        {
            OpenConnection();
            cmd = new MySqlCommand("UPDATE employeeshire SET terminationreason = @reason WHERE id = @id;", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@reason", reason);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        //UNUSED
        public object ShowDataInGridView(string Query_)
        {
            MySqlDataAdapter dr = new MySqlDataAdapter(Query_, connectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        //Update employee information
        public void UpdateEmployeeInformation(string id, string firstName, string lastName, int age, string gender, string email, string phone, string birthplace, string birthday, string city, int zip, string address, int securityNumber, string nationality, string fte, string hiredDate, string preferredWorkDays, string preferredShifts)
        {
            OpenConnection();
            cmd = new MySqlCommand("UPDATE employeeshire SET fname = @fname, lname = @lname, age = @age, gender = @gender, email = @email, phone = @phone, bplace = @bplace, bday = @bday, city = @city, zip = @zip, address = @address, snumber = @snumber, nationality = @nationality, fte = @fte, hdate = @hdate, wdays = @wdays, wshifts=@wshifts  WHERE id = @id;", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fname", firstName);
            cmd.Parameters.AddWithValue("@lname", lastName);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender",gender);
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
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public MySqlDataReader ShowDetailsUpdate(string id, TextBox t0, TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6, TextBox t7, TextBox t8,
            TextBox t9, TextBox t10, TextBox t11, TextBox t12, TextBox t13, TextBox t14,TextBox t15)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM employeeshire WHERE id = @id ;", sqlcon);
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
    }
}
