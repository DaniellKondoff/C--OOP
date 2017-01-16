using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Polymorphism
{
    public class Seaweed : Food
    {
        public Seaweed(string name, double nutritionalValue, int calories) 
            :base(name, nutritionalValue, calories)
        {
        }
    }
}
