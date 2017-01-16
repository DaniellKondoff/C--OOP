using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Polymorphism
{
    class Demo
    {
        static void Main()
        {
            Animal pengy = new Penguin("Pengy", "Fish", 5);
            Animal betsy = new Cow("Betsy", "Slama", 3);

            
            Console.WriteLine();
            List<Animal> animals = new List<Animal>();
            animals.Add(pengy);
            animals.Add(betsy);
            
            foreach (var animal in animals)
            {
                animal.MakeNoise();
            }

            foreach (var animal in animals)
            {
                string favFood = animal.StateFavFood();
            }
        }
    }
}
