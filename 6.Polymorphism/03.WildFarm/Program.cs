using _03.WildFarm.Animals;
using _03.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] line = Console.ReadLine().Split(' ');


                if (line[0]=="End")
                {
                    break;
                }

                string[] foodTokens = Console.ReadLine().Split(' ');

                Animal animal = null;
                Food food = null;

                switch (foodTokens[0].ToLower())
                {
                    case "meat":
                        food = new Meat(int.Parse(foodTokens[1]));
                        break;
                    case "vegatable":
                        food = new Vegetable(int.Parse(foodTokens[1]));
                        break;
                }

                string animalType = line[0];
                string animalName = line[1];
                double animalWeight = double.Parse(line[2]);
                string livingRegion = line[3];

                switch (animalType.ToLower())
                {
                    case "cat":
                        string breed = line[4];
                        animal = new Cat(animalType, animalName, animalWeight, livingRegion, breed);
                        break;
                    case "tiger":
                        animal = new Tiger(animalType,animalName, animalWeight, livingRegion);
                        break;
                    case "zebra":
                        animal = new Zebra(animalType,animalName, animalWeight, livingRegion);
                        break;
                    case "mouse":
                        animal = new Mause(animalType,animalName, animalWeight, livingRegion);
                        break;
                }

                
                animal.MakeSound();
                
                Console.WriteLine(animal);
                
                
            }
        }
    }
}
