using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultInterfaceMethods
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine(message);

        void ILogger.Log(Exception exception)
        {
            Console.WriteLine($"Exception type: {exception.GetType().Name}. Message: {exception.Message}.");
        }
    }
}
