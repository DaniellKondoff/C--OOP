using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.WildFarm.Foods;

namespace _03.WildFarm.Animals
{
    class Cat : Felime
    {
        private string breed;

        public Cat(string animalType, string animalName, double animalWeigh,string livingRegion,string breed) 
            : base(animalType, animalName, animalWeigh,livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed {
            get
            { return this.breed; }
            set
            {
                this.breed = value;
            }
        }

        public override void EatFood(Food food)
        {
            int currentFood = this.FoodEaten;
            if (food.FoodQuantity > 0)
            {
                this.FoodEaten = (currentFood + food.FoodQuantity);
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return String.Format("{0}[{1} {2} {3:f1} {4} {5}]",
                GetType().Name,
                this.AnimalName,
                this.Breed,
                this.AnimalWeight,
                this.LivingRegion,
                this.FoodEaten);
        }
    }
}
