using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class GreetingService
    {
        public string Greet(Person person)
        {
            return $"Hello, {person.FirstName}!";
        }
    }
}
