using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritance
{
    public record Position(int X, int Y);

    public record Size(int Width, int Height);

    public abstract record Shape(Position Position, Size Size)
    {
        public void Draw() => DisplayShape();

        protected virtual void DisplayShape()
        {
            Console.WriteLine($"Shape with {Position} and {Size}.");
        }
    }
}
