using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo.Iterators
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
            //return new BooksIterator(this.books);

            for (int i = 0; i < this.books.Count; i++)
            {
                yield return this.books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class BooksIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex = -1;

            public BooksIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }

            
            public Book Current
            {
                get
                {
                    return this.books[this.currentIndex];
                }
            }

            object IEnumerator.Current => this.Current;
           

            public void Dispose()
            {              
            }

            public bool MoveNext()
            {
                this.currentIndex+=2;
                if (this.currentIndex >=this.books.Count)
                {
                    return false;
                }
                return true;
            }

            public void Reset()
            {
                this.currentIndex = -2;
            }
        }
    }

   
}
