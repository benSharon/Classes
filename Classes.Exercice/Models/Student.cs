using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exercice.Models
{
    class Student
    {
        private DateTime _birthday;
        private string _firstName;
        private string _lastName;

        public int Age { get => DateTime.Today.Year - _birthday.Year; }
        public DateTime Birthday { get => _birthday; }
        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public string FullName { get => _lastName + ", " + _firstName; }
            

        public Student(string LastName, string FirstName, DateTime Birthday)
        {
            _birthday = Birthday;
            _firstName = FirstName;
            _lastName = LastName;
        }
    }
}
