using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Polymorphism
{
    public class Cow : Animal
    {
        int bodyMassInvex = 15;

        public Cow(string name, string favouriteFood, int age) 
            : base(name, favouriteFood, age)
        {
        }

        public override void ConsumeFood(Food food)
        {
            this.bodyMassInvex += food.calories/10;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Moo");
        }

         
    }
}
