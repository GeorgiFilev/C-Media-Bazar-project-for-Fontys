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

namespace CheckingWorkApp
{
    class SqlManager
    {
        MySqlConnection sqlcon;


        private MySqlCommand cmd;
        string connectionString = "Server=studmysql01.fhict.local;Uid=dbi432557;Database=dbi432557;Pwd=vedsalta;";

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
            try
            {
                sqlcon = new MySqlConnection(connectionString);
                sqlcon.Open();
            }
            catch(Exception e)
            {
                throw new FieldAccessException("You are not connected to Cisco");
            }
        }

        public void CloseConnection()
        {
            sqlcon.Close();
        }

    }
}
