using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vichicles
{
    class Car : Vehicle
    {
        private const double AirCondition = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void DriveDistance(double distance)
        {
            double fullConsumtion = this.FuelConsumption + AirCondition;
            double travelDistance = distance * fullConsumtion;

            if (travelDistance <= this.FuelQuantity)
            {
                double tempQuantity = this.FuelQuantity - travelDistance;
                this.FuelQuantity = tempQuantity;
                Console.WriteLine("Car travelled {0} km",distance);
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }
    }
}
