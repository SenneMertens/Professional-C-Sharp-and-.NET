using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultInterfaceMethods
{
    public interface ILogger
    {
        void Log(string message);

        public void Log(Exception exception) => Log(exception.Message);
    }
}
