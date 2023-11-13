using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StockAppMediaBazaar
{
    class SqlConnTermination
    {
        SQLConnection sqlMain = new SQLConnection();
        MySqlCommand cmd = new MySqlCommand();
        public void SendTerminationRequest(string id)
        {
           sqlMain.OpenConnection();
            cmd = new MySqlCommand("UPDATE employees SET terminationrequest = 1 WHERE id = @id;", sqlMain.SqlConn());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            sqlMain.CloseConnection();
        }
        public void SendTerminationReason(string id, string reason)
        {
            sqlMain.OpenConnection();
            cmd = new MySqlCommand("UPDATE employees SET terminationreason = @reason WHERE id = @id;", sqlMain.SqlConn());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@reason", reason);
            cmd.ExecuteNonQuery();
            sqlMain.CloseConnection();
        }
    }
}
