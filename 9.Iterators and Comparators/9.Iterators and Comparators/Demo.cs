using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Iterators_and_Comparators
{
   public class Demo
    {
       public static void Main(string[] args)
        {
            //Iterators
            var books = new BooksCollection();

            books.Add(new Book { Title = "Pesho" });
            books.Add(new Book { Title = "Ivan" });
            books.Add(new Book { Title = "gosho" });
            books.Add(new Book { Title = "Asparyh" });
            books.Add(new Book { Title = "Stamat" });


            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }

            //Comparators

            var sortedSet = new SortedSet<Book>();

            sortedSet.Add(new Book { Title = "Ivan", Authoor = "Gosho" });
            sortedSet.Add(new Book { Title = "Dani", Authoor = "Zoo" });
            sortedSet.Add(new Book { Title = "Abc", Authoor = "Stamat" });

            foreach (var item in sortedSet)
            {
                Console.WriteLine(item.Authoor);
            }

            var anotherSet = new SortedSet<Book>(new BookComparer());

        }
    }
}
