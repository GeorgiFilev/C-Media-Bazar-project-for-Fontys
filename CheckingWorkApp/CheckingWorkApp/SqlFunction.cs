using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CheckingWorkApp
{
    class SqlFunction
    {
        private SqlManager mngr = new SqlManager();
        private MySqlCommand cmd;
        private List<Person> people;
        private List<Shift> shifts;

        public SqlFunction()
        {
            mngr = new SqlManager();
            people = new List<Person>();
            shifts = new List<Shift>();
        }
        public void PopulateAllPeople()
        {
            mngr.OpenConnection();
            cmd = new MySqlCommand("SELECT id, fname, lname FROM employees ;", mngr.SqlConn());
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    Person p = new Person(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString());
                    people.Add(p);
                }
                catch (ExecutionEngineException e)
                {
                    throw new ExecutionEngineException(" cannot convert something");
                }
            }
            mngr.CloseConnection();
        }
        public List<Person> GetPeople()
        {
            return people;
        }
        public bool CheckPassword(int id, string password)
        {

            mngr.OpenConnection();
            cmd = new MySqlCommand("SELECT password FROM employees WHERE id=@id ;", mngr.SqlConn());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr[0]) == password)
                {
                    mngr.CloseConnection();
                    return true;
                }
            }
            mngr.CloseConnection();
            return false;

        }
        public void PopulateShifts(int id)
        {
            
            mngr.OpenConnection();
            cmd = new MySqlCommand("SELECT id, day, shift, week, status, start FROM shifts WHERE employeeid=@id ; ", mngr.SqlConn());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {

                STATUS status;
                if (dr[4].ToString()=="Upcoming")
                {
                     status = STATUS.Upcoming;
                    Shift s = new Shift(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), Convert.ToInt32(dr[3]), status);
                    shifts.Add(s);
                }
                else if(dr[4].ToString()=="Open")
                {
                     status = STATUS.Open;
                    Shift s = new Shift(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), Convert.ToInt32(dr[3]), status, Convert.ToDateTime(dr[5].ToString()));
                    shifts.Add(s);
                }
                else if(dr[4].ToString() == "Closed")
                {
                     status = STATUS.Closed;
                    Shift s = new Shift(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), Convert.ToInt32(dr[3]), status, Convert.ToDateTime(dr[5].ToString()));
                    shifts.Add(s);
                }
               
            }
            mngr.CloseConnection();
        }
        public List<Shift> GetShifts()
        {
            if(shifts != null)
            {
                return shifts;
            }
            else
            {
                return null;
            }
            throw new NullReferenceException("there are no shifts for this person!");
        }
        public void StartShift(int id)
        {
            foreach(Shift s in shifts)
            {
                if(s.ID==id)
                {
                    s.Status = STATUS.Open;
                    UpdateStatus(id);
                }
            }
        }
        public void EndShift(int id)
        {
            foreach (Shift s in shifts)
            {
                if (s.ID == id)
                {
                    s.Status = STATUS.Closed;
                    UpdateStatus(id);
                }
            }
        }
        public void UpdateStatus(int id)
        {
            mngr.OpenConnection();
            foreach(Shift s in shifts)
            {
                if(s.ID==id)
                {
                    cmd = new MySqlCommand("UPDATE shifts SET status = @status where id = @id ;", mngr.SqlConn());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@status", s.Status.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
            mngr.CloseConnection();
        }
        public void UpdateStartOfShift(int id,DateTime start)
        {
            mngr.OpenConnection();
            foreach (Shift s in shifts)
            {
                if (s.ID == id)
                {
                    cmd = new MySqlCommand("UPDATE shifts SET start = @start where id=@id ; ", mngr.SqlConn());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.ExecuteNonQuery();
                }
            }
            mngr.CloseConnection();
        }
        public void UpdateWorktime(int id,DateTime duration)
        {
            mngr.OpenConnection();
            foreach(Shift s in shifts)
            {
                if(s.ID == id)
                {
                    cmd = new MySqlCommand("UPDATE shifts SET worktime = @worktime where id=@id ; ",mngr.SqlConn());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@worktime", duration);
                    cmd.ExecuteNonQuery();
                }
            }
            mngr.CloseConnection();
        }
        public string GetWorkTimeDuration(int id)
        {
            mngr.OpenConnection();
            foreach (Shift s in shifts)
            {
                if (s.ID == id)
                {
                    cmd = new MySqlCommand("SELECT worktime FROM shifts where id= @id ; ", mngr.SqlConn());
                    cmd.Parameters.AddWithValue("@id", id);
                
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        string STRING_be_da_go_eba_stigalagva = dr[0].ToString();
                        mngr.CloseConnection();
                        return STRING_be_da_go_eba_stigalagva;
                    }
                }
            }
            
            mngr.CloseConnection();
            return null;
        }
    }
}
