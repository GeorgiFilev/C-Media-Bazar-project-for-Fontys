using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ManagerAppMediaBazaar
{
    public class SQLConnection
    {
        
        private static string connectionString = "Server=studmysql01.fhict.local;Uid=dbi432557;Database=dbi432557;Pwd=vedsalta;";
        MySqlConnection mysqlcon;
        public MySqlConnection Mysqlcon { get { return this.mysqlcon; } }
        public void OpenConnection()
        {
            mysqlcon = new MySqlConnection(connectionString);
            mysqlcon.Open();
        }
        public void CloseConnection()
        {
            mysqlcon.Close();
        }


    }
    }
