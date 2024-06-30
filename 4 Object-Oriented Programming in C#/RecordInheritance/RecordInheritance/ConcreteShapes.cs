using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritance
{
    public record Rectangle(Position Position, Size Size) : Shape(Position, Size)
    {
        protected override void DisplayShape()
        {
            Console.WriteLine($"Rectangle with {Position} and {Size}.");
        }
    }

    public record Ellipse(Position Position, Size Size) : Shape(Position, Size)
    {
        protected override void DisplayShape()
        {
            Console.WriteLine($"Ellipse with {Position} and {Size}.");
        }
    }
}
