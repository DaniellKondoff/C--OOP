using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Animals
{
    public abstract class Felime : Mammal
    {
        public Felime(string animalType, string animalName, double animalWeigh, string livingRegion) 
            : base(animalType, animalName, animalWeigh, livingRegion)
        {
        }
    }
}
