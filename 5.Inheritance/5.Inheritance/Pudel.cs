using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Inheritance
{
    class Pudel : Dog
    {
        public bool hasCurcless;

        private const int Age = 1;

        public Pudel(int age)
            :base(age)
        {

        }
        public Pudel()
            :base(Age)
        {
             
        }
        public void TellHimToWalk()
        {
            base.Walk();
        }
        private new void Walk()
        {
            Console.WriteLine("");
        }

        
        
    }
}
