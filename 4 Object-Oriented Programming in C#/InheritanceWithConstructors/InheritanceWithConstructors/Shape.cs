using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructors
{
    public class Position
    {
        public int X { get; }

        public int Y { get; }

        public Position(int x, int y) => (X, Y) = (x, y);

        public override string ToString() => $"X: {X}, Y: {Y}";
    }

    public class Size
    {
        public int Width { get; }

        public int Height { get; }

        public Size(int width, int height) => (Width, Height) = (width, height);

        public override string ToString() => $"Width: {Width} Height: {Height}";
    }

    public abstract class Shape
    {
        public Position Position { get; }

        public Size Size { get; }

        public Shape(int x, int y, int width, int height)
        {
            Position = new Position(x, y);
            Size = new Size(width, height);
        }

        public void Draw() => DisplayShape();

        protected virtual void DisplayShape()
        {
            Console.WriteLine($"Shape with {Position} and {Size}.");
        }

        public abstract Shape Clone();
    }
}
