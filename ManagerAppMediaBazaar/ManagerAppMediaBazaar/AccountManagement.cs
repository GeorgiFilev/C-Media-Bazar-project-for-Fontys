using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAppMediaBazaar
{
    class AccountManagement
    {
        List<string> departments = new List<string>();
        List<string> deletedDepartments = new List<string>();
        SQLConnAccounts sqlAcc = new SQLConnAccounts();


        public void UpdateAccount(int id, string username, string pass, string job)
        {
            sqlAcc.UpdateDatabase(id, username, pass, job);
        }
        public void UpdateDepartment(string newName, string name, int availability)
        {
            sqlAcc.UpdateDatabaseDepartments(newName, name, availability);
        }
        public void AddDepartment(string name, int availability)
        {
            sqlAcc.AddDatabaseDepartments(name, availability);
        }
        public string[] GetDepartments()
        {
            return this.departments.ToArray();
        }
        public string[] GetDeletedDepartments()
        {
            return this.deletedDepartments.ToArray();
        }
        public void UpdateDepartmentsList() //updates list from db
        {
            departments = sqlAcc.UpdateListDepartments().ToList();
            deletedDepartments = sqlAcc.UpdateListDeletedDepartments().ToList();
        }
    }
}
