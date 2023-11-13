using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAppMediaBazaar
{
     class Login : SQLConnLogin
    {
        public bool ValidateCredentials(string email, string password)
        {
            if(LoginQueries(email, password))
            {
                return true;
            }
            return false;
        }
    }
}
