using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Polymorphism
{
    public class Penguin : Animal
    {
        public int wingPower;

        public Penguin(string name, string favouriteFood, int age) 
            : base(name, favouriteFood, age)
        {
        }

        public new string StateFavFood()
        {
            return "fish";
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Peeep");
        }

        public override void ConsumeFood(Food food)
        {
            this.wingPower += food.calories;
        }
    }
}
