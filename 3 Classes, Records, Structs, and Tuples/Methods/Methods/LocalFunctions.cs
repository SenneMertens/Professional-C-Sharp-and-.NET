using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class LocalFunctions
    {
        private int _int1;

        public int Int1
        {
            get
            {
                void foo() => Console.WriteLine("Foo");

                foo();

                return _int1;
            }
            set
            {
                _int1 = value;
            }
        }

        public static void LocalFunction()
        {
            static int Add(int int1, int int2) => int1 + int2;

            int result1 = Add(3, 7);

            Console.WriteLine($"Called the local function with the result: {result1}.");
        }

        public static void LocalFunctionWithClosure()
        {
            int int3 = 3;
            int result1 = Add(1, 2);

            Console.WriteLine($"Called the local function with closure with the result: {result1}.");

            int Add(int int1, int int2) => int1 + int2 + int3;
        }
    }
}
