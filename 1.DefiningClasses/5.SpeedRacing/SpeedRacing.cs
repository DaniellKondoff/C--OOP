using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SpeedRacing
{
    public class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelCostForKm;
        public double distance;
        public Car(string model,double fuelAmount,double fuelCostForKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelCostForKm = fuelCostForKm;
            this.distance = 0;
        }

        public void Drive(int amountOfKm)
        {
            if (amountOfKm<=(this.fuelAmount/this.fuelCostForKm))
            {
                this.distance += amountOfKm;
                this.fuelAmount -= amountOfKm * fuelCostForKm;

            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }


    }
    public class SpeedRacing
    {
        public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carsInfo = Console.ReadLine().Split();

                Car car = new Car(carsInfo[0],double.Parse(carsInfo[1]),double.Parse(carsInfo[2]));
                cars.Add(car);
            }

            string driveCommand = Console.ReadLine();
            while (driveCommand != "End")
            {
                string[] driveInfo = driveCommand.Split();

                string carModel = driveInfo[1];
                int amountOfKm = int.Parse(driveInfo[2]);

                Car carToDrive = cars.First(c => c.model == carModel);
                carToDrive.Drive(amountOfKm);

                driveCommand = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine("{0} {1:f2} {2}",car.model,car.fuelAmount,car.distance);
            }
        }
    }
}
