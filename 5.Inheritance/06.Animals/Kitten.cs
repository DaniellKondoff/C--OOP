using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    class Kitten : Cat , Sound
    {
        public Kitten(string name,int age)
            :base(name,age,"Female")
        {
        }

        public override  string produceSound()
        {
            return "Miau";
        }
    }
}
