using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Iterators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int CompareTo(Book book)
        {
            var authorCompare = this.Author.CompareTo(book.Author);
            if (authorCompare!=0)
            {
                return authorCompare;
            }

            return this.Title.CompareTo(book.Title);
        }
    }
}
