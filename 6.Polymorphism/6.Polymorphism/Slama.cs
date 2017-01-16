using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Polymorphism
{
    class Slama : Food
    {
        public Slama(string name, double nutritionalValue, int calories) 
            : base(name, nutritionalValue, calories)
        {
        }
    }
}
