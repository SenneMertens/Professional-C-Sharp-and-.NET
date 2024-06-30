﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class Position
    {
        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString() => $"X: {X}, Y: {Y}";
    }

    public class Size
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public override string ToString() => $"Width: {Width}, Height: {Height}";
    }

    public class Shape
    {
        public Position Position { get; } = new();

        public virtual Size Size { get; } = new();

        public void Draw() => DisplayShape();

        protected virtual void DisplayShape()
        {
            Console.WriteLine($"Shape with {Position} and {Size}.");
        }

        public virtual Shape Clone() => throw new NotImplementedException();

        public virtual void Move(Position newPosition)
        {
            Position.X = newPosition.X;
            Position.Y = newPosition.Y;

            Console.WriteLine($"moved to {Position}.");
        }
    }
}
