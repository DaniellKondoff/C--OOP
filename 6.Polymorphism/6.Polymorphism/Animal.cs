using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Polymorphism
{
    public abstract class Animal
    {
        string name;
        string favouriteFood;
        int age;

        public Animal(string name, string favouriteFood, int age)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
            this.age = age;
        }

        public virtual string StateFavFood()
        {
            return this.favouriteFood;
        }

        public abstract void MakeNoise();

        public abstract void ConsumeFood(Food food);
       
    }
}
