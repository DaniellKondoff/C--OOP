using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Animals
{
    public abstract class Animal : IAnimal
    {
        public readonly int NumberOfEyes = 2;

        public Animal()
        {
            this.NumberOfEyes = 15;
        }

        public string Name { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public abstract string SayHello();

    }
}
