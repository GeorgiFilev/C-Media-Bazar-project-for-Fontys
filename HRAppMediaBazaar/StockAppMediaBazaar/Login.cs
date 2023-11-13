using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAppMediaBazaar
{
    class Login
    {
        SqlConnLogin sqlConnLogin = new SqlConnLogin();
        public bool ValidateCredentials(string email, string password)
        {
            if (sqlConnLogin.LoginQueries(email, password))
            {
                return true;
            }
            return false;
        }
    }
}
