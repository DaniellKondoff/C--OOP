namespace Demo
{
    using Comperators;
    using Iterators;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            //Iterator
            var books = new BooksCollection();

            books.Add(new Book { Title = "Pesho" });
            books.Add(new Book { Title = "Ivan" });
            books.Add(new Book { Title = "Gosho" });
            books.Add(new Book { Title = "Asparyh" });
            books.Add(new Book { Title = "Stamat" });
            books.Add(new Book { Title = "Vanio" });

            foreach (var book in books)
            {
                //System.Console.WriteLine(book.Title);
            }

            //Compare

            var sortedSet = new SortedSet<Book>();

            sortedSet.Add(new Book { Title = "Zebra", Author = "Zoo" });
            sortedSet.Add(new Book{ Title = "Ivan", Author = "Gosho" });
            sortedSet.Add(new Book { Title = "Cba", Author = "Stamat" });
            sortedSet.Add(new Book { Title = "Abc", Author = "Stamat" });

            foreach (var book in sortedSet)
            {
                System.Console.WriteLine(book.Author);
            }

            var anotherSet = new SortedSet<Book>(new BookComparer());

        }
    }
}
