using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Inheritance
{
    class Cat:Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Myu");
        }

        public override void ValidateAge(int age)
        {
            base.ValidateAge(age);
            if (age > 15)
            {
                throw new ArgumentException();
            }
            Console.WriteLine(age);
        }
    }
}
