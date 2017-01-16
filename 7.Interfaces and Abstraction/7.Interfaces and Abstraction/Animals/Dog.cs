using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Interfaces_and_Abstraction.Animals
{
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override string SayHello()
        {
            return "Bow";
        }
    }
}
