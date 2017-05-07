using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Cars
{
    public class Audi : ICar
    {
        public Audi(string model)
        {
            this.Model = model;
        }

        public string Model { get; private set; }
 

        public void Start()
        {
            Console.WriteLine("AUDI Brum");
        }

        public void Stop()
        {
            Console.WriteLine("Audi Stop");
        }
    }
}
