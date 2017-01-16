using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.WildFarm.Foods;

namespace _03.WildFarm.Animals
{
    class Tiger : Felime
    {
        public Tiger(string animalType, string animalName, double animalWeigh, string livingRegion) 
            : base(animalType, animalName, animalWeigh, livingRegion)
        {
        }

        public override void EatFood(Food food)
        {
            if (((Food)food).GetType().Name.Equals("Vegetable"))
            {
                throw new ArgumentException("Tigers are not eating that type of food!");
            }

            int currentFood = this.FoodEaten;
            if (food.FoodQuantity > 0)
            {
                this.FoodEaten = (currentFood + food.FoodQuantity);
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}
