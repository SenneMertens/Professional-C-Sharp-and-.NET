using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Rectangle : Shape
    {
        public override Rectangle Clone()
        {
            Rectangle rectangle1 = new();

            rectangle1.Position.X = Position.X;
            rectangle1.Position.Y = Position.Y;
            rectangle1.Size.Width = Size.Width;
            rectangle1.Size.Height = Size.Height;

            return rectangle1;
        }

        public override void Move(Position newPosition)
        {
            Console.Write("Rectangle ");

            base.Move(newPosition);
        }

        protected override void DisplayShape()
        {
            Console.WriteLine($"Rectangle at position {Position} with size {Size}.");
        }
    }

    public class Ellipse : Shape
    {
        public override Shape Clone()
        {
            Ellipse ellipse1 = new();

            ellipse1.Position.X = Position.X;
            ellipse1.Position.Y = Position.Y;
            ellipse1.Size.Width = Size.Width;
            ellipse1.Size.Height = Size.Height;

            return ellipse1;
        }

        public override void Move(Position newPosition)
        {
            Console.Write("Ellipse: ");

            base.Move(newPosition);
        }

        protected override void DisplayShape()
        {
            Console.WriteLine($"Ellipse at position {Position} with size {Size}.");
        }
    }

}
