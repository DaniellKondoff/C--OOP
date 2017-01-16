using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    class Tomcat : Cat , Sound
    {
        public Tomcat(string name, int age)
            :base(name,age,"Male")
        {
        }

        public override string produceSound()
        {
            return "Give me one million b***h";
        }
    }
}
