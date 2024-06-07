using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class PeopleFactory
    {
        private static int _peopleCount;

        public static int PeopleCount => _peopleCount;

        public static Person CreatePerson(string firstName, string lastName)
        {
            _peopleCount++;

            return new Person(firstName, lastName);
        }
    }
}
