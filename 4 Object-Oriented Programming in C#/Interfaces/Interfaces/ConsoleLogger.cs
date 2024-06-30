using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ConsoleLogger : ILogger
    {
        void ILogger.Log(string message) => Console.WriteLine(message);
    }
}
