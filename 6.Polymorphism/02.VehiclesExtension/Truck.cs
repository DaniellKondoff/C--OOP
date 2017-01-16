using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension
{
    class Truck : Vehicle
    {
        private const double AirCondition = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
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
                Console.WriteLine("Truck travelled {0} km", distance);
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void RefuelWithLiters(double liters)
        {
            base.RefuelWithLiters(liters - (liters * 0.05));
        }
    }
}
