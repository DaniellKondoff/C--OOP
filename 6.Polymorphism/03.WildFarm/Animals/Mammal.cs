using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;
        public Mammal(string animalType, string animalName, double animalWeigh,string livingRegion) 
            : base(animalType, animalName, animalWeigh)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return String.Format("{0}[{1} {3:f1} {4} {5}]",
                this.AnimalType,
                this.AnimalName,
                this.AnimalWeight,
                this.LivingRegion,
                this.FoodEaten);
        }
    }
}
