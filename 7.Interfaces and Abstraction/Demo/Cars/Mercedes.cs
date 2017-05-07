using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Cars
{
    class Mercedes : ICar
    {
        public Mercedes(string model)
        {
            this.Model = model;
        }
        public string Model { get; private set; }
  
        public void Start()
        {
            Console.WriteLine("Brum!");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Brum!");
        }
    }
}
