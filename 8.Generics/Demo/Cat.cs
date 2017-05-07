using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void Eat<T>(T food)
        {
            Console.WriteLine("" + food.ToString());
        }
    }
}
