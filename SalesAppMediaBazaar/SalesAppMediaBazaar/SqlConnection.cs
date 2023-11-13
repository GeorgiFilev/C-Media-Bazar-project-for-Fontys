using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesAppMediaBazaar
{
    class SqlConnection
    {
        private MySqlConnection sqlcon;
      
        public SqlConnection()
        {
            this.sqlcon = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi432557;Database=dbi432557;Pwd=vedsalta;");
        }

        public MySqlConnection SqlConn()
        {
            return this.sqlcon;
        }

        public void Open()
        {
            try
            {
                sqlcon.Open();
            }
            catch(FieldAccessException ex)
            {
                throw new Exception("Can not open the connection");
            }
        }
        public void Close()
        {
            try
            {
                sqlcon.Close();
            }
            catch(FieldAccessException ex)
            {
                throw new Exception("Can not close the connection");
            }
        }
      

        
       
    }
}
