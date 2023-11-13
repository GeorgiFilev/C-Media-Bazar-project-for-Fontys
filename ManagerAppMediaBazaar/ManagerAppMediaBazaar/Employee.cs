using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAppMediaBazaar
{
    class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private Gender gender;
        private string email;
        private string phone;
        private string birthplace;
        private string birthday;
        private string city;
        private string zip;
        private string address;
        private string securityNumber;
        private string nationality;
        private string fte;
        private string hiredDate;
        private Weekdays preferredWorkDays;
        private ShiftType preferredShift;
        private int nrOfTerminations;
        private string terminationReason;
        private bool terminationRequest;
        private bool employmentRequest;
        private string companyRole;
        private string password;

        public int Id { get { return this.id; } }
        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public string Email { get { return this.email; } }
        public bool TerminationRequest {get{ return this.terminationRequest; }  set { this.terminationRequest = value; } }
        public bool EmploymentRequest { get { return this.employmentRequest; } set { this.employmentRequest = value; } }
        public string CompanyRole { get { return this.companyRole; } }
        public string Password { get { return this.password; } }
        public string TerminationReason { get { return this.terminationReason; } set { this.terminationReason = value; } }
        public int NrOfTerminations { get { return this.nrOfTerminations; } set { this.nrOfTerminations = value; } }
        

        public Employee(string firstName, string lastName, int age, Gender gender, string email, string phone, string birthplace, string birthday, string city, string zip, string address, string securityNumber, string nationality, string fte, string hiredDate, Weekdays preferredWorkDays, ShiftType preferredShift, int nrOfTerminations, string terminationReason, bool terminationRequest, bool employmentRequest, string companyRole, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.email = email;
            this.phone = phone;
            this.birthplace = birthplace;
            this.birthday = birthday;
            this.city = city;
            this.zip = zip;
            this.address = address;
            this.securityNumber = securityNumber;
            this.nationality = nationality;
            this.fte = fte;
            this.hiredDate = hiredDate;
            this.preferredWorkDays = preferredWorkDays;
            this.preferredShift = preferredShift;
            this.nrOfTerminations = nrOfTerminations;
            this.terminationReason = terminationReason;
            this.terminationRequest = terminationRequest;
            this.employmentRequest = employmentRequest;
            this.companyRole = companyRole;
            this.password = password;
        }
        public Employee(int id, string firstName, string lastName, int age, string gender, string email, string phone, string birthplace, string birthday, string city, string zip, string address, string securityNumber, string nationality, string fte, string hiredDate, string preferredWorkDays, string preferredShifts, int nrOfTerminations, string terminationReason, bool terminationRequest, bool employmentRequest, string companyRole, string password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = (Gender)Enum.Parse(typeof(Gender), gender, true);
            this.email = email;
            this.phone = phone;
            this.birthplace = birthplace;
            this.birthday = birthday;
            this.city = city;
            this.zip = zip;
            this.address = address;
            this.securityNumber = securityNumber;
            this.nationality = nationality;
            this.fte = fte;
            this.hiredDate = hiredDate;
            this.preferredWorkDays = (Weekdays)Enum.Parse(typeof(Weekdays), preferredWorkDays, true);
            this.preferredShift = (ShiftType)Enum.Parse(typeof(ShiftType), preferredShifts, true);
            this.nrOfTerminations = nrOfTerminations;
            this.terminationReason = terminationReason;
            this.terminationRequest = terminationRequest;
            this.employmentRequest = employmentRequest;
            this.companyRole = companyRole;
            this.password = password;
        }
        public override string ToString()
        {
            return  $"{this.id} {this.firstName} {this.lastName}";
        }
    }
}
