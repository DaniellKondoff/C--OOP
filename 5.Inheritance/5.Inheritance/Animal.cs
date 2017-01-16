using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Inheritance
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Sound!");
        }

        public virtual void ValidateAge(int age)
        {
            
            if (age<0)
            {
                throw new ArgumentException();
            }
        }
        
    }
}
