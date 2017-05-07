using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Cars
{
    public class Opel : Car
    {
        public new void Start()
        {
            Console.WriteLine("Burm Opel");
        }
    }
}
