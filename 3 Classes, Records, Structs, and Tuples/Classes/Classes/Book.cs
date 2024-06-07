using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Book
    {
        public string Title { get; init; }

        public string? Publisher { get; init; }

        public Book(string title) => Title = title;
    }
}
