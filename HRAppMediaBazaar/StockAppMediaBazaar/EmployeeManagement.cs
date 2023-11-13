using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockAppMediaBazaar
{
    class EmployeeManagement
    {
        SqlConnEmployee sqlEmp = new SqlConnEmployee();
        SqlConnTermination sqlTermination = new SqlConnTermination();
        public List<Employee> employees = new List<Employee>();
        List<string> departments = new List<string>();

        public void AddEmployeeToDb(string firstName, string lastName, int age, Gender gender, string email,
            string phone,
            string birthplace, string birthday, string city, string zip, string address, string securityNumber,
            string nationality, double fte, string hiredDate, Weekdays preferredWorkDays, ShiftType preferredShifts,
            string companyRole)
        {

            sqlEmp.EmployeeQuery(firstName, lastName, age, gender.ToString(), email, phone, birthplace, birthday, city,
                zip, address, securityNumber, nationality, fte, hiredDate, preferredWorkDays.ToString(),
                preferredShifts.ToString(), true, companyRole);
        }

        public void AddEmployeeFromDb(int id, string firstName, string lastName, int age, string gender, string email,
            string phone,
            string birthplace, string birthday, string city, string zip, string address, string securityNumber,
            string nationality, double fte, string hiredDate, string preferredWorkDays, string preferredShifts,
            int nrOfTerminations, string terminationReason, bool termRequest, bool emplRequest, string companyRole)
        {
            Employee em = new Employee(id, firstName, lastName, age, gender, email, phone, birthplace, birthday, city,
                zip,
                address, securityNumber, nationality, fte, hiredDate, preferredWorkDays, preferredShifts,
                nrOfTerminations, terminationReason, termRequest, emplRequest, companyRole);
            employees.Add(em);
        }

        public string[] AllEmployees()
        {
            List<string> empList = new List<string>();
            foreach (Employee em in employees)
            {
                if (!em.EmpRequest && em.NrOfTerminations!=1)
                {
                    empList.Add(em.ToString());
                }
            }

            return empList.ToArray();
        }

        public string[] SearchEmployeeInListBox(string text)
        {
            List<string> empsearch = new List<string>();
            string input = text.ToUpper();
            foreach (Employee em in employees)
            {
                if (!em.EmpRequest)
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

        public void UpdateEmployeeInfo(string id, string firstName, string lastName, int age, string gender,
            string email, string phone, string birthplace, string birthday, string city,string zip, string address,
            string securityNumber, string nationality, double fte, string hiredDate, string preferredWorkDays,
            string preferredShifts, string companyRole)
        {
            sqlEmp.UpdateEmployeeInformation(id, firstName, lastName, age, gender, email, phone, birthplace, birthday,
                city, zip, address, securityNumber, nationality, fte, hiredDate, preferredWorkDays, preferredShifts,
                companyRole);
        }

        public string[] EmployeeDetails(string id)
        {
            List<string> details = new List<string>();
            foreach (Employee e in employees)
            {
                if (e.Id == Convert.ToInt32(id))
                {
                    details.Add(e.Id.ToString());
                    details.Add(e.FirstName);
                    details.Add(e.LastName);
                    details.Add(e.Age.ToString());
                    details.Add(e.Gender.ToString());
                    details.Add(e.Email);
                    details.Add(e.Phone);
                    details.Add(e.Birthplace);
                    details.Add(e.Birthday);
                    details.Add(e.City);
                    details.Add(e.Zip);
                    details.Add(e.Address);
                    details.Add(e.SecurityNumber);
                    details.Add(e.Nationality);
                    details.Add(e.Fte.ToString());
                    details.Add(e.HiredDate);
                    details.Add(e.PreferredWorkDays.ToString());
                    details.Add(e.PreferredShift.ToString());
                    details.Add(e.NrOfTerminations.ToString());
                    details.Add(e.TerminationReason);
                    details.Add(e.TerminationRequest.ToString());
                    details.Add(e.EmpRequest.ToString());
                    details.Add(e.Roles.ToString());

                }
            }

            return details.ToArray();
        }

        //display employees id,first name and last name in listbox
        public void UpdateEmployeeList()
        {
            employees = sqlEmp.UpdateEmployeesFromDb().ToList();
        }

        //terminations
        public void SendTerminationRequest(string id)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Id == Convert.ToInt32(id))
                {
                    sqlTermination.SendTerminationRequest(employee.Id.ToString());
                }
            }

        }

        public void SendTerminationReason(string id, string reason)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Id == Convert.ToInt32(id))
                {
                    employee.TerminationReason = reason;
                    sqlTermination.SendTerminationReason(employee.Id.ToString(), employee.TerminationReason);
                }
            }

        }
        //validate user input 
        public string[] GetDepartments()
        {
            return departments.ToArray();
        }
        public void UpdateDepartmentsList() //updates list from db
        {
            departments = sqlEmp.UpdateListDepartments().ToList();
        }
    }
}
