using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Polymorphism
{
   public abstract class Food
    {
        public string name;
       public double nutritionalValue;
       public int calories;

        public Food(string name,double nutritionalValue, int calories)
        {
            this.name = name;
            this.nutritionalValue = nutritionalValue;
            this.calories = calories;
        }
    }
}
