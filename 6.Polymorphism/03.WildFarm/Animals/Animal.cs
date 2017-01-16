using _03.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Animals
{
   public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public Animal(string animalType, string animalName, double animalWeigh)
        {
            this.animalType = animalType;
            this.AnimalName = animalName;
            this.AnimalWeight = animalWeigh;
            this.FoodEaten = 0;
        }

        public string AnimalType { get; set; }
        public string AnimalName { get; set; }
        public double AnimalWeight { get; set; }
        public int FoodEaten {
            get
            {
                return this.foodEaten;
            }
            set
            {
                this.foodEaten = value;
            }
        }

        public abstract void MakeSound();

        public abstract void EatFood(Food food);
    }
}
