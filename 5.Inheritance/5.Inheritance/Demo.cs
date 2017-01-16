using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Inheritance
{
    class Demo
    {
        static void Main(string[] args)
        {
            Circle circle=new Circle(10,20,30);

            Console.WriteLine(circle.Radius);

            Shape shape = new Shape(2, 2);
            Console.WriteLine(shape.X+" "+shape.Y);

            Pudel pudi = new Pudel(5);
            Console.WriteLine(pudi.DogAge);

            Cat cat = new Cat();
            cat.MakeSound();
            cat.ValidateAge(5);

            Book book = new Book("Kniga");
            Console.WriteLine(book.Name);
            Console.WriteLine(book.name);
           
           
           
            
        }
    }
}
