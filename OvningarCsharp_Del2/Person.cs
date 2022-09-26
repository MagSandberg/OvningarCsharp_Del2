using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCsharp_Del2
{
    internal class Person
    {
        private string _firstName;
        public string FirstName
        { get { return _firstName; } set { _firstName = value; } }

        private string _lastName;
        public string LastName
        { get { return _lastName; } set { _lastName = value; } }

        private readonly string _name;
        public string Name
        {
            get { return _name; }
        }
        public string SetFullName(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            return FirstName + " " + LastName;
        }

        public Person(string firstname, string lastname)
        {
            _name = SetFullName(firstname, lastname);
        }
    }
}
