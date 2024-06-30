using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public record LinkedListNode<T>(T Value)
    {
        public LinkedListNode<T> Next { get; internal set; }

        public LinkedListNode<T> Prev { get; internal set; }

        public override string ToString() => Value?.ToString();
    }
}
