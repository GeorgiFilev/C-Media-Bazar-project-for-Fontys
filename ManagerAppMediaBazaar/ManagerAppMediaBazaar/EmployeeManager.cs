using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAppMediaBazaar
{
    class EmployeeManager
    {
        SQLConnectionContracts sqlEmp = new SQLConnectionContracts();
        List<Employee> employees = new List<Employee>();

        //home
        public string GetName(string email)
        {
            if (sqlEmp.GetNameFromDb(email)[1] == "Male")
            {
                return $"Welcome Mr. {sqlEmp.GetNameFromDb(email)[0]}";
            }
            else
            {
                return $"Welcome Ms. {sqlEmp.GetNameFromDb(email)[0]}";
            }
           
        }
        //Contracts form
        public void TerminateEmployee(string id) //terminates employment by assigning false and incrementing the num of terminaitons
        {
            foreach (Employee em in employees)
            {
                if (em.TerminationRequest && em.Id == Convert.ToInt32(id))
                {
                    em.TerminationRequest = false;
                    em.NrOfTerminations += 1;
                    sqlEmp.UpdateDatabase(id, em.NrOfTerminations, em.TerminationReason, em.TerminationRequest, em.EmploymentRequest);
                }
            }
        }
        public void DenyTerminationRequest(string id) //denies termination by assigning false to request and defaults the reason
        {
            foreach (Employee em in employees)
            {
                if (em.TerminationRequest && em.Id == Convert.ToInt32(id))
                {
                    em.TerminationRequest = false;
                    em.TerminationReason = "Not assigned";
                    sqlEmp.UpdateDatabase(id, em.NrOfTerminations, em.TerminationReason, em.TerminationRequest, em.EmploymentRequest);
                }
            }
        }
        public string ViewTerminationReason(string id) // returns a string with the termination reason
        {
            string reason = "Not assigned";

            foreach (Employee em in employees)
            {
                if (em.TerminationRequest && em.Id == Convert.ToInt32(id))
                {
                    reason = em.TerminationReason;
                }
            }
            return reason;
        }
        public string[] ViewTerminationRequest() // returns a list with the employee basic info
        {
            List<string> empToBeFired = new List<string>();

            foreach (Employee em in employees)
            {
                if (em.TerminationRequest)
                {
                    empToBeFired.Add(em.ToString());
                }
            }
            return empToBeFired.ToArray();
        }
        public void ApproveEmploymentRequest(string id) // approves emp req by assigning false
        {
            foreach (Employee em in employees)
            {
                if (em.EmploymentRequest && em.Id == Convert.ToInt32(id))
                {
                    em.EmploymentRequest = false;
                    sqlEmp.UpdateDatabase(id, em.NrOfTerminations, em.TerminationReason, em.TerminationRequest, em.EmploymentRequest);
                }
            }
        }
        public void DenyEmploymentRequest(string id) //denies employment request by removing from the list
        {
            foreach (Employee em in employees)
            {
                if (em.EmploymentRequest && em.Id == Convert.ToInt32(id))
                {
                    sqlEmp.DeleteEmployeeDb(id);
                }
            }
        }
        public string[] ViewEmploymentRequest() // returns a list with the employee basic info
        {
            List<string> empToBeFired = new List<string>();

            foreach (Employee em in employees)
            {
                if (em.EmploymentRequest)
                {
                    empToBeFired.Add(em.ToString());
                }
            }
            return empToBeFired.ToArray();
        }

        // Accounts Management Form
        public string[] GetAccountInfo(int id)
        {
            List<string> empInfo = new List<string>();
            foreach (Employee em in employees)
            {
                if (em.Id == id)
                {
                    empInfo.Add(em.Email);
                    empInfo.Add(em.Password);
                    empInfo.Add(em.CompanyRole);
                }
            }
            return empInfo.ToArray();
        }
        public string[] GetNoAccounts()
        {
            List<string> empList = new List<string>();
            foreach (Employee em in employees)
            {
                if (!em.EmploymentRequest && em.Password == "N/A" && em.NrOfTerminations < 1)
                {
                    empList.Add(em.ToString());
                }
            }
            return empList.ToArray();
        }
        public string[] GetAccounts()
        {
            List<string> empList = new List<string>();
            foreach (Employee em in employees)
            {
                if (!em.EmploymentRequest && em.Password != "N/A" && em.NrOfTerminations < 1)
                {
                    empList.Add(em.ToString());
                }
            }
            return empList.ToArray();
        }
        public string[] SearchNoAccounts(string text) //searches HIRED employees with no accounts
        {
            List<string> empsearch = new List<string>();
            string input = text.ToUpper();
            foreach (Employee em in employees)
            {
                if (!em.EmploymentRequest && em.Password == "N/A" && em.NrOfTerminations<1) //checks if employee is hired and has no account
                {
                    string fullname = em.FirstName + " " + em.LastName;
                    if (em.FirstName.ToUpper().Contains(input) || em.LastName.ToUpper().Contains(input) || em.Id.ToString() == input ||
                        fullname.ToUpper().Contains(input))
                    {
                        empsearch.Add(em.ToString());
                    }
                }
            }
            return empsearch.ToArray();
        }
        public string[] SearchAccounts(string text) //searches  employees with accounts
        {
            List<string> empsearch = new List<string>();
            string input = text.ToUpper();
            foreach (Employee em in employees)
            {
                if (!em.EmploymentRequest && em.Password != "N/A" && em.NrOfTerminations < 1) //checks if employee is hired and has an account
                {
                    string fullname = em.FirstName + " " + em.LastName;
                    if (em.FirstName.ToUpper().Contains(input) || em.LastName.ToUpper().Contains(input) || em.Id.ToString() == input ||
                        fullname.ToUpper().Contains(input))
                    {
                        empsearch.Add(em.ToString());
                    }
                }
            }
            return empsearch.ToArray();
        }
        public void UpdateEmployeeList() //updates list from db
        {
            employees = sqlEmp.UpdateListEmployees().ToList();
        }
    }
    }
