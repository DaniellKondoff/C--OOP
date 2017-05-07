using Demo.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Comperators
{
    public class CustomBookComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Title.IndexOf("a");
        }
    }
}
