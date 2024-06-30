using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultInterfaceMethods
{
    public interface IEnumerableEx<T> : IEnumerable<T>
    {
        public IEnumerable<T> Where(Func<T, bool> pred)
        {
            foreach (T item in this)
            {
                if (pred(item))
                {
                    yield return item;
                }
            }
        }
    }
}
