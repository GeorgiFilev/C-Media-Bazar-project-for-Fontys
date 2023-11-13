using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingWorkApp
{
    class Person
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id,string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public int GetID()
        {
            return this.id;
        }
        public string ToString()
        {
            return $"{this.firstName} {this.lastName}";
        }
    }
}
