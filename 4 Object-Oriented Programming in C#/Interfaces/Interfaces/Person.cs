using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public record Person(string FirstName, string LastName) : IComparable<Person>
    {
        public int CompareTo(Person? other)
        {
            int compare = LastName.CompareTo(other?.LastName);

            if (compare is 0)
            {
                return FirstName.CompareTo(other?.FirstName);
            }

            return compare;
        }
    }
}
