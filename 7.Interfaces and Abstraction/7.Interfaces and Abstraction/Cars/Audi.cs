using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Interfaces_and_Abstraction.Cars
{
    class Audi : ICar
    {
        public Audi(string model)
        {
            this.Model = model;
        }
        public string Model
        {
            get; private set;
        }

        public void Start()
        {
            Console.WriteLine("Audi Start");
        }

        public void Stop()
        {
            Console.WriteLine("Audi Stop");
        }
    }
}
