using _7.Interfaces_and_Abstraction.Animals;
using _7.Interfaces_and_Abstraction.Cars;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace _7.Interfaces_and_Abstraction
{
    class Demo
    {
        static void Main(string[] args)
        {
            List<Animal> listOfAnimals = new List<Animal>();
            HashSet<Animal> listAnimals = new HashSet<Animal>();
            Animal someAnimal = new Cat("hih");
            someAnimal.SayHello();

            listOfAnimals.Add(someAnimal);
            listOfAnimals.Add(new Dog(""));
            listOfAnimals.Add(new Bunny(""));

            foreach (var animal in listOfAnimals)
            {
                Console.WriteLine(animal.SayHello());
            }


            var cars = new List<ICar>();

            cars.Add(new Audi("A6"));
            cars.Add(new Mercedes("C class"));

            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
                car.Start();
            }

        }

        
    }
}
