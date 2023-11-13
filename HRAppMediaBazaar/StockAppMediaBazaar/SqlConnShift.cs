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
    /*steps for the algorithm
     #1 - random assigning
        1 - send employment request to manager
        2 - manager approves the request 
        3 - algorithm checks if 3 people(number is not important) have a shift on a specific day(starting from monday)
        4 - if its not true , the algorithm assigns the employee to a random day
        4.5 - algorithm checks that 1 employee can not work 2 shifts in 1 day
        5 - if it is true , algorithm looks at the next day until it finds a free shift
        6 - if there are no free shifts - message saying there no available shifts for the week
        7 - algorithm checks if the specific employee has been assigned more than 2 shifts for the week(number is not important)
        8 - if its true - message saying the employee can not take any more shifts
        9 - if its not true - assign the employee to the next free shift 
        10 - algorithm moves to next week number and repeats the previous steps

    #2 - algorithm assigning but not random

        1 - send employment request to manager
        2 - manager approves the request 
        3 - algorithm checks if 3 people(number is not important) have a shift on a specific day(starting from monday)
        4 - if its not true , the algorithm assigns the employee to the specific day
        4.5 - algorithm checks that 1 employee can not work 2 shifts in 1 day
        5 - if it is true , algorithm looks at the next day until it finds a free shift
        6 - if there are no free shifts - message saying there no available shifts for the week
        7 - algorithm checks if the specific employee has been assigned more than 2 shifts for the week(number is not important)
        8 - if its true - message saying the employee can not take any more shifts
        9 - if its not true - assign the employee to the next free shift 
        10 - algorithm moves to next week number and repeats the previous steps
     */

    class SqlConnShift
    {
        SQLConnection sqlMain = new SQLConnection();
        MySqlCommand cmd = new MySqlCommand();
        public void AddShiftToDB(int employeeid,string fname, string lname, string day, string shift, string week, string companyRole)
        {
            sqlMain.OpenConnection();
            cmd = new MySqlCommand("Insert into shifts (employeeid,fname,lname,day,shift,week,companyRole) VALUES (@employeeid,@fname,@lname,@day,@shift,@week,@role)",sqlMain.SqlConn());
            cmd.Parameters.AddWithValue("@employeeid", employeeid);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@shift", shift);
            cmd.Parameters.AddWithValue("@week", week);
            cmd.Parameters.AddWithValue("@role", companyRole);
            cmd.ExecuteNonQuery();
           sqlMain.CloseConnection();
        }
        public Shift[] UpdateShiftListFromDb()
        {

            List<Shift> listShiftsDb = new List<Shift>();
            sqlMain.OpenConnection();

            string sql = $"Select * from shifts order by id ;"; //ORDER BY DATE??
            MySqlCommand cmd = new MySqlCommand(sql, sqlMain.SqlConn());
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listShiftsDb.Add(new Shift(Convert.ToInt32(dr[0]),Convert.ToInt32(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4]), Convert.ToString(dr[5]), Convert.ToString(dr[6]), Convert.ToString(dr[7])));
            }
            sqlMain.CloseConnection();
            return listShiftsDb.ToArray();

        }
        public void DeleteShift(int shiftid)
        {
            sqlMain.OpenConnection();
            cmd = new MySqlCommand("DELETE FROM shifts WHERE id = @shiftid", sqlMain.SqlConn());
            cmd.Parameters.AddWithValue("@shiftid", shiftid);
           
            cmd.ExecuteNonQuery();
            sqlMain.CloseConnection();
        }
        public void UpdateShiftSQL(int id,string day,string shift)
        {
            sqlMain.OpenConnection();
            cmd = new MySqlCommand("UPDATE shifts SET  day= @day, shift= @shift WHERE id= @id", sqlMain.SqlConn());
            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@shift", shift);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            sqlMain.CloseConnection();
        }
        //step 4 - select day from database 
        public int GetShiftsPerDay(int week, string day)
        {
            try
            {
                int count = 0;
                sqlMain.OpenConnection();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM shifts WHERE day = @day AND week = @week ORDER BY day;", sqlMain.SqlConn());
                cmd.Parameters.AddWithValue("@day", day);
                cmd.Parameters.AddWithValue("@week", week);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0] != null)
                    {
                        count = Convert.ToInt32(dr[0]);
                    } 
                }
                sqlMain.CloseConnection();
                return count;
            }
            catch (Exception e)
            {
                throw new Exception("Kur za maika ti");
            }
            

        }
        public int CountEmployeeShifts(int id,int week, string day)
        {
            try
            {
                int count = 0;
                sqlMain.OpenConnection();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM shifts WHERE  id = @id AND day = @day AND week = @week  ORDER BY day;", sqlMain.SqlConn());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@week", week);
                cmd.Parameters.AddWithValue("@day", day);
                
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0] != null)
                    {
                        count = Convert.ToInt32(dr[0]);
                    }
                }
                sqlMain.CloseConnection();
                return count;
            }
            catch (Exception e)
            {
                throw new Exception("Kur za maika ti");
            }
        }
        public bool CheckForSameShiftDB(int id, int week, string day, string shift)
        {
            sqlMain.OpenConnection();
            cmd = new MySqlCommand("SELECT shift FROM shifts WHERE  id = @id AND day = @day AND week = @week  AND shift = @shift;", sqlMain.SqlConn());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@week", week);
            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@shift", shift);

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0] == null)
                {
                    sqlMain.CloseConnection();
                    return false;
                }
            }
            sqlMain.CloseConnection();
            return true;
           
        }
        
    }
    
}
