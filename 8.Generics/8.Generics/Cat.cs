using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Generics
{
    class Cat
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public void Eat<T>(T food)
        {
            Console.WriteLine("Eating "+food.ToString());
        }

        
    }
}
