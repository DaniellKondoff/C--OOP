using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Inheritance
{
    class Dog
    {
        //private string name;
        private int dogAge;

        public Dog(int dogAge)
        {
            //this.name = name;
            this.dogAge = dogAge;
        }

        public int DogAge {
           get { return this.dogAge; }

           private set
            {
                if (value<0)
                {
                    throw new ArgumentException();
                }

                this.dogAge = value;
            }
        }

        public void Walk()
        {
            Console.WriteLine("Dee");
        }


        public void Bark()
        {
            Console.WriteLine("Bark");
        }
        
       
    }
}
