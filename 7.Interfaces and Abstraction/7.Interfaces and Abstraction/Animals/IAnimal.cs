using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Interfaces_and_Abstraction.Animals
{
    public interface IAnimal
    {
        string Name { get; }

        string Color { get; }

        string SayHello();
    }
}
