using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Animals;
using Demo.Cars;

namespace Demo
{
    class StartUp
    {
        static void Main()
        {
            Animal cat = new Cat();

            var cars = new List<ICar>();

            cars.Add(new Audi("A6"));
            cars.Add(new Mercedes("CL"));

            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
                car.Start();
                car.Stop();
            }
        }
    }
}
