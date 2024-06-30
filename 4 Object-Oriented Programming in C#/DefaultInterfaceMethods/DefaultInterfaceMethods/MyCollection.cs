using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultInterfaceMethods
{
    public class MyCollection<T> : Collection<T>, IEnumerableEx<T>
    {
    }
}
