using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0608Test
{
    internal class LibraryItem
    {
        protected internal string title;
        public string GetTitle() { return title; }
    }

    internal class Book:LibraryItem
    {
        public Book() { title = "third question"; }
    }
}
