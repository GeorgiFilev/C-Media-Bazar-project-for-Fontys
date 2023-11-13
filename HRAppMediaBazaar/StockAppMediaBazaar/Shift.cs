using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAppMediaBazaar
{
    class Shift
    {
        public int ShiftId { get; private set; }
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }        
        public Weekdays Day { get; private set; }
        public ShiftType Type { get; private set; }
        public string Week { get; private set; }
        public string CompanyRole { get; private set; }
        

        public Shift(int shiftId,int employeeId,string firstName,string lastName,string day,string type,string week,string companyRole)
        {
            this.ShiftId = shiftId;
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;            
            this.Day = (Weekdays)Enum.Parse(typeof(Weekdays), day, true);
            this.Type = (ShiftType)Enum.Parse(typeof(ShiftType), type, true);
            this.Week = week;
            this.CompanyRole = companyRole;
        }

        public override string ToString()
        {
            return $"{"#"}{this.ShiftId}    {this.FirstName} {this.LastName}     {this.Day}         {this.Type}         {this.CompanyRole}";
        }

    }
}
