using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private int _age;

        public string FirstName => _firstName;

        public string LastName => _lastName;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string FullName => $"{FirstName} {LastName}";

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }
    }
}
