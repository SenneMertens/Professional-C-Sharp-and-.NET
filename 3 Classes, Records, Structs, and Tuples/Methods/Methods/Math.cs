using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Math
    {
        public int Value { get; set; }

        public int GetSquare => Value * Value;

        public static int GetSquareOff(int int1) => int1 * int1;

        public static double GetPi() => 3.14159;
    }
}
