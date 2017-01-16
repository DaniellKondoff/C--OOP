using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carLine = Console.ReadLine().Split(' ');
            Vehicle car = new Car(double.Parse(carLine[1]), double.Parse(carLine[2]), double.Parse(carLine[3]));

            string[] truckLine = Console.ReadLine().Split(' ');
            Vehicle truck = new Truck(double.Parse(truckLine[1]), double.Parse(truckLine[2]), double.Parse(truckLine[3]));

            string[] busLine = Console.ReadLine().Split(' ');
            Vehicle bus = new Bus(double.Parse(busLine[1]), double.Parse(busLine[2]), double.Parse(busLine[3]));

            int numCmd = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCmd; i++)
            {
                string[] vichlesTokens = Console.ReadLine().Split(' ');
                string cmd = vichlesTokens[0];
                string vichles = vichlesTokens[1];
                double quantity = double.Parse(vichlesTokens[2]);

                switch (vichles)
                {
                    case "Car":
                        if (cmd.Equals("Drive"))
                        {
                            car.DriveDistance(quantity);
                        }
                        else
                        {
                            car.RefuelWithLiters(quantity);
                        }
                        break;
                    case "Truck":
                        if (cmd.Equals("Drive"))
                        {
                            truck.DriveDistance(quantity);
                        }
                        else
                        {
                            truck.RefuelWithLiters(quantity);
                        }
                        break;
                    case "Bus":
                        if (cmd.Equals("Drive"))
                        {
                            bus.DriveDistance(quantity);
                        }
                        else if (cmd.Equals("DriveEmpty"))
                        {
                            ((Bus)bus).DriveEmpty(quantity);
                        }
                        else
                        {
                            bus.RefuelWithLiters(quantity);
                        }
                        break;
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");

        }
    }
}
