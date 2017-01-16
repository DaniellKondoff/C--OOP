using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Iterators_and_Comparators
{
   public class BooksCollection : IEnumerable<Book>
    {
        private readonly List<Book> books;

        public BooksCollection()
        {
            this.books = new List<Book>();
        }
        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < this.books.Count; i++)
            {
                yield return this.books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


       

    }

}
