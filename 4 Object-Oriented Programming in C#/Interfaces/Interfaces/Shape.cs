using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Shape : ILogger
    {
        public Position? Position { get; set; }

        public Size? Size { get; set; }

        protected ILogger Logger { get; }

        public Shape(ILogger logger)
        {
            Logger = logger;
        }

        public void Draw() => DisplayShape();

        public void Log(string message) => Console.WriteLine(message);

        protected virtual void DisplayShape()
        {
            Logger.Log($"Shape with {Position} and {Size}");
        }
    }

    public record Position(int X, int Y);

    public record Size(int Width, int Height);
}
