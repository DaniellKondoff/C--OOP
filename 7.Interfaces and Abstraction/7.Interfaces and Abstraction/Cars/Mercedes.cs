using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Interfaces_and_Abstraction.Cars
{
    public class Mercedes : ICar
    {
        public Mercedes(string model)
        {
            this.Model = model;
        }
        public string Model
        {
            get; private set;
            
        }

        public void Start()
        {
            Console.WriteLine("Start");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
