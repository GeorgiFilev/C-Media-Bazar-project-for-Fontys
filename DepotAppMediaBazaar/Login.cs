using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepotAppMediaBazaar
{
    class Login
    {
        //private string email;
        //private string password;
        SQLConnLogin connLogin = new SQLConnLogin();
        public bool ValidateCredentials(string email, string password)
        {
            if (connLogin.LoginQueries(email, password))
            {
                return true;
            }
            return false;
        }
    }
}
