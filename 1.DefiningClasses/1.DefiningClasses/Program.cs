using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefiningClasses
{
    public class Program
    {
        public static void Main()
        {
            var firstBook = new Book();

            firstBook.name = "Stihotvorenenie na Botev";
            firstBook.pages = 150;
            firstBook.price = 20.00m;
            firstBook.description = "Stihotvorenie";

            var secondBook = new Book()
            {
                name = "Pod Igoto",
                pages = 300,
                price = 30.00m,
                description = "Voinata"
            };

            string someName = secondBook.name;

            var firstAuthor = new Author("Hristo","Botev")
            {
                yearOfBirth = 1848
            };

            firstBook.author = firstAuthor;

            Console.WriteLine(firstBook.author.firstName);


            firstAuthor.books.Add(firstBook);
            Console.WriteLine(firstAuthor.books.Count);

            // Constructor

            var secondAuthor = new Author("Ivan");

        }
    }
}
