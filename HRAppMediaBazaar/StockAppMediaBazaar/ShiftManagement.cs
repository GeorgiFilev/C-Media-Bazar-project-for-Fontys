using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAppMediaBazaar
{
    public class ShiftManagement
    {
        private List<Shift> shifts;
        SqlConnShift connShift = new SqlConnShift();
        SqlConnEmployee sqlEmp = new SqlConnEmployee();
        private List<Employee> employees = new List<Employee>();
        List<Employee> empSales = new List<Employee>();
        List<Employee> empDepot = new List<Employee>();
        List<int> nrOfShiftsPerDay = new List<int>();

        Random random = new Random();
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        public ShiftManagement()
        {
            shifts = new List<Shift>();

            dictionary.Add(1, "Monday");
            dictionary.Add(2, "Tuesday");
            dictionary.Add(3, "Wednesday");
            dictionary.Add(4, "Thursday");
            dictionary.Add(5, "Friday");
            dictionary.Add(6, "Saturday");
            dictionary.Add(7, "Sunday");
            dictionary.Add(8, "Monday");
            dictionary.Add(9, "Tuesday");
            dictionary.Add(10, "Wednesday");
        }

        //step 1
        public bool AutoAssigner(int week)
        {
            UpdateEmployeeList();
            if (employees.Count <= 0)
            {
                return false;
            }
            else
            {
                SplitEmployees();
                while (AssignDepotWorkers(week))
                {
                }
                while (AssignSalesWorkers(week))
                {
                }
                return true;
            }
        }

        //step 2

        public void SplitEmployees()
        {

            foreach (Employee emp in employees)
            {
                if (emp.Roles.Contains("Depot"))
                {
                    empDepot.Add(emp);
                }
            }

            foreach (Employee emp in employees)
            {
                if (emp.Roles.Contains("Sales"))
                {
                    empSales.Add(emp);
                }
            }
        }

        //step 3
        /// <summary>
        /// assings a depot worker to a shift
        /// </summary>
        /// <param name="week"> week number </param>
        /// <returns>true if employee is done, false if everyone has been assigned</returns>
        public bool AssignDepotWorkers(int week) //returns true if employee is done, false if everyone has been assigned (list is empty)
        {
            if (empDepot.Count <= 0)
            {
                return false;
            }
            else
            {
                //select a random employee from depot list using random
                Employee empTempDepot = empDepot[random.Next(0, empDepot.Count - 1)];
                double totalFteDepot = empTempDepot.Fte;
                string dayLeastShifts = DayWithLeastShifts(week);
                string shift = GetRandomShift();
                if (ShiftValidations(empTempDepot.Id, week, dayLeastShifts, shift))
                {
                    connShift.AddShiftToDB(empTempDepot.Id, empTempDepot.FirstName, empTempDepot.LastName, dayLeastShifts, shift, week.ToString(),
                        empTempDepot.Roles);
                    totalFteDepot -= 0.1;
                    shift = GetRandomShift();
                    // fix the returns in the method 
                }
                foreach (int i in dictionary.Keys) //not optimal could be improved!!! has a small chance for mistake
                {
                    if (totalFteDepot > 0.1) 
                    {
                        if (ShiftValidations(empTempDepot.Id, week, dictionary[i], shift))
                        {
                            connShift.AddShiftToDB(empTempDepot.Id, empTempDepot.FirstName, empTempDepot.LastName,
                                dictionary[i], shift, week.ToString(), empTempDepot.Roles);
                            totalFteDepot -= 0.1;
                            shift = GetRandomShift();
                        }
                    }
                }
                empDepot.Remove(empTempDepot);
                return true;
            }
        }
        public bool AssignSalesWorkers(int week) //returns true if employee is done, false if everyone has been assigned (list is empty)
        {
            if (empSales.Count <= 0)
            {
                return false;
            }
            else
            {
                //select a random employee from depot list using random
                Employee empTempSales = empSales[random.Next(0, empSales.Count - 1)];
                double totalFteSales = empTempSales.Fte;
                string dayLeastShifts = DayWithLeastShifts(week);
                string shift = GetRandomShift();
                if (ShiftValidations(empTempSales.Id, week, dayLeastShifts, shift))
                {
                    connShift.AddShiftToDB(empTempSales.Id, empTempSales.FirstName, empTempSales.LastName, dayLeastShifts, shift, week.ToString(),
                        empTempSales.Roles);
                    totalFteSales -= 0.1;
                    shift = GetRandomShift();
                    // fix the returns in the method 
                }
                foreach (int i in dictionary.Keys) //not optimal could be improved!!! has a small chance for mistake
                {
                    if (totalFteSales > 0.1)
                    {
                        if (ShiftValidations(empTempSales.Id, week, dictionary[i], shift))
                        {
                            connShift.AddShiftToDB(empTempSales.Id, empTempSales.FirstName, empTempSales.LastName,
                                dictionary[i], shift, week.ToString(), empTempSales.Roles);
                            totalFteSales -= 0.1;
                            shift = GetRandomShift();
                        }
                    }
                }
                empSales.Remove(empTempSales);
                return true;
            }
        }
        public bool ShiftValidations(int id, int week, string day, string shift)
        {
            if (connShift.CountEmployeeShifts(id, week, day) == 2 || !connShift.CheckForSameShiftDB(id, week, day, shift))
            {
                return false;
            }
            return true;
        }

        //bonus step -gets a random shift 
        public string GetRandomShift()
        {
            Dictionary<int, string> shifts = new Dictionary<int, string>();
            shifts.Add(1, "Morning");
            shifts.Add(2, "Afternoon");
            shifts.Add(3, "Night");
            string shift = shifts[random.Next(1, 4)];

            return shift;
        }

        //step 4.5 - call the method 7 times for each day
        public string DayWithLeastShifts(int week)
        {


            nrOfShiftsPerDay.Clear();
            nrOfShiftsPerDay.Add(connShift.GetShiftsPerDay(week, "Monday"));
            nrOfShiftsPerDay.Add(connShift.GetShiftsPerDay(week, "Tuesday"));
            nrOfShiftsPerDay.Add(connShift.GetShiftsPerDay(week, "Wednesday"));
            nrOfShiftsPerDay.Add(connShift.GetShiftsPerDay(week, "Thursday"));
            nrOfShiftsPerDay.Add(connShift.GetShiftsPerDay(week, "Friday"));
            nrOfShiftsPerDay.Add(connShift.GetShiftsPerDay(week, "Saturday"));
            nrOfShiftsPerDay.Add(connShift.GetShiftsPerDay(week, "Sunday"));

            for (int i = 0; i < nrOfShiftsPerDay.Count; i++)
            {
                if (nrOfShiftsPerDay.Min() == nrOfShiftsPerDay[i])
                {
                    string day = dictionary[i + 1];
                    return day;
                }
            }
            return null;
        }

        public bool AssignSalesWorkers()
        {
            if (empSales.Count < 0)
            {
                return false;
            }
            else
            {
                Employee empTemp = empSales[random.Next(0, empSales.Count)];
                return true;
            }
        }

        public bool AddShift(int employeeId, string fname, string lname, string day, string shift, string week,
            string companyRole)
        {
            UpdateShiftList();

            foreach (Shift sh in shifts)
            {
                if (sh.EmployeeId == employeeId && sh.Day.ToString() == day && sh.Week == week)
                {
                    return false;
                    //throw new Exception("Shift has already been assigned.");                    

                }

            }

            connShift.AddShiftToDB(employeeId, fname, lname, day.ToString(), shift.ToString(), week, companyRole);
            return true;

        }

        public void UpdateShiftList()
        {
            shifts = connShift.UpdateShiftListFromDb().ToList();

        }

        public void UpdateShift(int id, string day, string shift)
        {
            connShift.UpdateShiftSQL(id, day, shift);
        }

        public void DeleteShift(int shiftid)
        {
            connShift.DeleteShift(shiftid);
        }

        public string[] AllShifts(int week)
        {
            List<string> shList = new List<string>();
            foreach (Shift sh in shifts)
            {
                if (sh.Week == week.ToString())
                {
                    shList.Add(sh.ToString());
                }
            }

            return shList.ToArray();
        }

        public string[] SearchShiftInListBox(string text)
        {
            List<string> shsearch = new List<string>();
            string input = text.ToUpper();
            foreach (Shift sh in shifts)
            {

                if (sh.FirstName.ToUpper().Contains(input) || sh.LastName.ToUpper().Contains(input) ||
                    sh.ShiftId.ToString() == input ||
                    sh.Type.ToString() == input)
                {
                    shsearch.Add(sh.ToString());
                }


            }

            return shsearch.ToArray();
        }

        public void UpdateEmployeeList()
        {
            employees = sqlEmp.UpdateEmployeesFromDb().ToList();
        }

        public string[] GetEmployeeInfoFromShifts(string week, string day, string shift)
        {
            List<string> names = new List<string>();
            foreach (Shift sh in shifts)
            {
                if (sh.Week == week && sh.Day.ToString() == day && sh.Type.ToString() == shift)
                {
                    names.Add($"#{sh.ShiftId}  {sh.FirstName} {sh.LastName} {sh.CompanyRole}");
                }
            }
            return names.ToArray();
        }

        //public string[] SearchEmployeeInListBox(string text)
        //{
        //    List<string> empsearch = new List<string>();
        //    string input = text.ToUpper();
        //    foreach (Employee em in employees)
        //    {
        //        if (!em.EmpRequest)
        //        {
        //            string fullname = em.FirstName + " " + em.LastName;
        //            if (em.FirstName.ToUpper().Contains(input) || em.LastName.ToUpper().Contains(input) || em.Id.ToString() == input ||
        //                fullname.ToUpper().Contains(input))
        //            {
        //                empsearch.Add(em.ToString());
        //            }
        //        }

        //    }

        //    return empsearch.ToArray();
        //}
    }
}


