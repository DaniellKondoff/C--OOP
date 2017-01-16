using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.SpeedRacing
{
    public class Car
    {
        public Car(string model,double fuel,double fuelConsumpyion)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelConsumpyion = fuelConsumpyion;
            this.distanceTraveled = 0;
        }

        public Car()
        {
        }

        public string model;
        public double fuel;
        public double fuelConsumpyion;
        public double distanceTraveled;

        public void Drive(int amountOfKilometers)
        {
            if(amountOfKilometers <= (this.fuel / this.fuelConsumpyion))
            {
                this.distanceTraveled += amountOfKilometers;
                this.fuel -= this.fuelConsumpyion * amountOfKilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
    public class SpeedRacing
    {
        public static void Main()
        {
            var carsList = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car car = new Car(model, fuel, fuelConsumption);
                carsList.Add(car);
            }

            string driveCommand = Console.ReadLine();
            while (driveCommand != "End")
            {
                string[] driveCommandsArgs = driveCommand.Split();
                string carModel = driveCommandsArgs[1];
                int amountOfKilometers = int.Parse(driveCommandsArgs[2]);

                Car carToDrive = carsList.First(c => c.model == carModel);
                carToDrive.Drive(amountOfKilometers);
                driveCommand = Console.ReadLine();
            }

            foreach (var car in carsList)
            {
                Console.WriteLine("{0} {1:F2} {2}",car.model,car.fuel,car.distanceTraveled);
            }
        }
    }
}
