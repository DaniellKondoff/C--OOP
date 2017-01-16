using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Iterators_and_Comparators
{
   public class Book : IComparable<Book>
    {
        public string Title { get; set; }

        public string Authoor { get; set; }

        public int CompareTo(Book other)
        {
            var authorCompare = this.Authoor.CompareTo(other.Authoor);

            if (authorCompare != 0)
            {
                return authorCompare;
            }

            return this.Title.CompareTo(other.Title);
        }
    }
}
