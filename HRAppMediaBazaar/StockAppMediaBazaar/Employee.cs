using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAppMediaBazaar
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
        private double fte;
        private string hiredDate;
        private Weekdays preferredWorkDays;
        private ShiftType preferredShift;
        private int nrOfTerminations;
        private string terminationReason;
        private bool terminationRequest;
        private bool employmentRequest;
        private string companyRole;

        public int Id
        {
            get { return this.id; }
            
        }

        public string FirstName
        {
            get { return this.firstName; }
        }
        public string LastName
        {
            get { return this.lastName; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public Gender Gender
        {
            get { return this.gender; }
        }

        public string Email
        {
            get { return this.email; }
        }

       
        public string Phone
        {
            get { return this.phone; }
        }
        public string Birthplace
        {
            get { return this.birthplace; }
        }
        public string Birthday
        {
            get { return this.birthday; }
        }
        public string City
        {
            get { return this.city; }
        }
        public string Zip
        {
            get { return this.zip; }
        }
        public string Address
        {
            get { return this.address; }
        }
        public string SecurityNumber
        {
            get { return this.securityNumber; }
        }
        public string Nationality
        {
            get { return this.nationality; }
        }
        public double Fte
        {
            get { return this.fte;}
            set { this.fte = value; }
        }
        public string HiredDate
        {
            get { return this.hiredDate; }
        }
        public Weekdays PreferredWorkDays
        {
            get { return this.preferredWorkDays; }
        }
        public ShiftType PreferredShift
        {
            get { return this.preferredShift; }
        }
        public int NrOfTerminations
        {
            get { return this.nrOfTerminations; }
        }
        public string TerminationReason
        {
            get { return this.terminationReason; }
            set { this.terminationReason = value; }
        }

        public bool TerminationRequest
        {
            get { return this.terminationRequest; }
        }
        public bool EmpRequest
        {
            get { return this.employmentRequest; }
        }

        public string Roles
        {
            get { return this.companyRole;}
        }

        public Employee(string firstName, string lastName, int age, Gender gender, string email, string phone, string birthplace, string birthday, string city, string zip, string address, string securityNumber, string nationality, double fte, string hiredDate, Weekdays preferredWorkDays, ShiftType preferredShifts,string companyRole)
        {
                this.firstName=firstName;
                this.lastName=lastName;
                this.age = age;
                this.gender = gender;
                this.email = email;
                this.phone=phone;
                this.birthplace=birthplace;
                this.birthday=birthday;
                this.city=city;
                this.zip=zip;
                this.address=address;
                this.securityNumber=securityNumber;
                this.nationality=nationality;
                this.fte = fte;
                this.hiredDate = hiredDate;
                this.preferredWorkDays = preferredWorkDays;
                this.preferredShift = preferredShifts;

                this.companyRole = companyRole;

        }

        public Employee(int id, string firstName, string lastName, int age, string gender, string email,
            string phone, string birthplace, string birthday, string city, string zip, string address,
            string securityNumber, string nationality, double fte, string hiredDate, string preferredWorkDays,
            string preferredShifts,int nrOfTerminations,string terminationReason,bool terminationRequest,bool employmentRequest,string companyRole)
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
            this.preferredShift = (ShiftType)Enum.Parse(typeof(ShiftType),preferredShifts, true);
            this.nrOfTerminations = nrOfTerminations;
            this.terminationReason = terminationReason;
            this.terminationRequest = terminationRequest;
            this.employmentRequest = employmentRequest;
            this.companyRole = companyRole;
        }

       


        public override string ToString()
        {
            return $"{"#"}{this.id}  {this.firstName}  {this.lastName}";
        }
    }
}

