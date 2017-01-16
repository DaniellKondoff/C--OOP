using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Car
{
    public class Car
    {
        public int speed;
        public int fuel;
        public int fuelEconomy;
        public int distance;
        public Car(int speed, int fuel, int fuelEconomy)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelEconomy = fuelEconomy;
            this.distance = 0;
        }
        public void Travel(int distance)
        {
            this.distance += distance;
            this.fuel -= this.fuelEconomy;
        }
        public void Refuel(int liters)
        {
            this.fuel += liters;
        }
        public void Distance()
        {
            Console.WriteLine("Total distance: {0:f1} kilometers", this.distance);
        }
        public void Time()
        {
            int time = this.distance / this.speed;
            Console.WriteLine("Total time: {0} hours and 0 minutes", time);
        }

        public void Fuel()
        {
            Console.WriteLine("Fuel left: {0:f1} liters", this.fuel);
        }
    }
    public class Carr
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Car car = new Car(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]));
            List<Car> cars = new List<Car>();
            input = Console.ReadLine().Split();
            while (input[0] != "END")
            {

                if (input[0] == "Travel")
                {
                    car.Travel(int.Parse(input[1]));
                }
                else if (input[0] == "Refuel")
                {
                    car.Refuel(int.Parse(input[1]));
                }
                else if (input[0] == "Distance")
                {
                    car.Distance();
                }
                else if (input[0] == "Time")
                {
                    car.Time();
                }
                else
                {
                    car.Fuel();
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
