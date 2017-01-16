using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Interfaces_and_Abstraction.Animals
{
    public abstract class  Animal : IAnimal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public string Color { get; set; }

        public abstract string SayHello();
    }
}
