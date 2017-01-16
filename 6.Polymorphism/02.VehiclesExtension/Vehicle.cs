using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension
{
   public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption,double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            set
            {
                this.tankCapacity = value;
            }
        }

        public abstract void DriveDistance(double distance);

        public virtual void RefuelWithLiters(double liters)
        {
            this.fuelQuantity += liters;
        }
    }
}
