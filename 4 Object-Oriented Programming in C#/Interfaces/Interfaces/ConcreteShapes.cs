using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Rectangle : Shape
    {
        public Rectangle(ILogger logger) : base(logger) { }

        protected override void DisplayShape()
        {
            Logger.Log($"Rectangle at position {Position} and size {Size}");
        }
    }

    public class Ellipse : Shape
    {
        public Ellipse(ILogger logger) : base(logger) { }

        protected override void DisplayShape()
        {
            Logger.Log($"Rectangle at position {Position} and size {Size}");
        }
    }
}
