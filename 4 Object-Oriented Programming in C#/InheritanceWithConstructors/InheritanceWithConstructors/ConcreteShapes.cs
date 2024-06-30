using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructors
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height) { }

        public override Rectangle Clone() => new(Position.X, Position.Y, Size.Width, Size.Height);

        protected override void DisplayShape()
        {
            Console.WriteLine($"Rectangle at position {Position} with size {Size}.");
        }
    }

    public class Ellipse : Shape
    {
        public Ellipse(int x, int y, int width, int height) : base(x, y, width, height) { }

        public override Ellipse Clone() => new(Position.X, Position.Y, Size.Width, Size.Height);

        protected override void DisplayShape()
        {
            Console.WriteLine($"Ellipse at position {Position} with size {Size}.");
        }
    }
}
