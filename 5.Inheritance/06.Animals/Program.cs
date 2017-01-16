using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    class Program
    {
        static void Main()
        {
            try
            {
                while (true)
                {
                    string line = Console.ReadLine();

                    if (line.Equals("Beast!"))
                    {
                        break;
                    }

                    string[] animalTokens = null;
                    string name = null;
                    int age = 0;
                    string gender = null;
                    Animal animal = null;

                    switch (line)
                    {
                        case "Dog":
                            animalTokens = Console.ReadLine().Split(' ');
                            name = animalTokens[0];
                            age = int.Parse(animalTokens[1]);
                            gender = animalTokens[2];
                            animal = new Dog(name, age, gender);
                            break;
                        case "Cat":
                            animalTokens = Console.ReadLine().Split(' ');
                            name = animalTokens[0];
                            age = int.Parse(animalTokens[1]);
                            gender = animalTokens[2];
                            animal = new Cat(name, age, gender);
                            break;
                        case "Frog":
                            animalTokens = Console.ReadLine().Split(' ');
                            name = animalTokens[0];
                            age = int.Parse(animalTokens[1]);
                            gender = animalTokens[2];
                            animal = new Frog(name, age, gender);
                            break;
                        case "Kitten":
                            animalTokens = Console.ReadLine().Split(' ');
                            name = animalTokens[0];
                            age = int.Parse(animalTokens[1]);
                            gender = animalTokens[2];
                            animal = new Kitten(name, age);
                            break;
                        case "Tomcat":
                            animalTokens = Console.ReadLine().Split(' ');
                            name = animalTokens[0];
                            age = int.Parse(animalTokens[1]);
                            gender = animalTokens[2];
                            animal = new Tomcat(name, age);
                            break;
                        case "Animal":
                            animalTokens = Console.ReadLine().Split(' ');
                            name = animalTokens[0];
                            age = int.Parse(animalTokens[1]);
                            gender = animalTokens[2];
                            animal = new Animal(name, age, gender);
                            break;
                    }

                    if (animal != null)
                    {
                        Console.WriteLine(animal.GetType().Name);
                        Console.WriteLine(animal);
                        Console.WriteLine(animal.produceSound());
                    }
                }
            }

            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
