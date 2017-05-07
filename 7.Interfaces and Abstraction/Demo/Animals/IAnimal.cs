using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Animals
{
    public interface IAnimal
    {
        string Name { get; }

        string Color { get; }

        string SayHello();
    }
}
