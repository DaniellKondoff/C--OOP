using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.CarSalesman
{
    public class Engine
    {
        
        public string model;
        public int power;
        public int displacement;
        public string efficiency;

        public Engine(string model, int power) : this(model,power,-1,@"n/a")
        {
                
        }
        public Engine(string model,int power,int displacement) : this (model,power,displacement,@"n/a")
        {

        }
        public Engine(string model,int power,string efficiency): this(model,power,-1,efficiency)
        {

        }
        public Engine(string model,int power,int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }
    }

    public class Car
    {
        public string model;
        public Engine engine;
        public int weight;
        public string color;

        public Car(string model, Engine engine):this(model,engine,-1,@"n/a")
        {

        }
        public Car(string model, Engine engine,int weight):this(model,engine,weight,@"n/a")
        {

        }
        public Car(string model, Engine engine, string color):this(model,engine,-1,color)
        {

        }
        public Car(string model,Engine engine,int weight,string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }
    }
    public class CarSalesman
    {
        public static void Main()
        {
            List <Car> carsList= new List<Car>();
            List<Engine> engineList = new List<Engine>();
            int numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                Engine engine = null;
                int displacement = 0;
                if (engineInfo.Length == 2)
                {
                    engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]));
                }
                if (engineInfo.Length == 4)
                {
                    engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]) ,int.Parse(engineInfo[2]),engineInfo[3]);

                }
                else if (engineInfo.Length == 3 && int.TryParse(engineInfo[2],out displacement))
                {
                    engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]), displacement);
                }
                else
                {
                    engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]), engineInfo[2]);
                }
                engineList.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new char[] { },StringSplitOptions.RemoveEmptyEntries);
                Car car = null;
                int weigth = 0;
                Engine engine = engineList.First(e => e.model == carInfo[1]);
                if (carInfo.Length == 2)
                {
                    car = new Car(carInfo[0], engine);
                }
                else if (carInfo.Length == 4)
                {          
                        car = new Car(carInfo[0], engine,int.Parse(carInfo[2]),carInfo[3]); 
                }
                else if (carInfo.Length == 3 && int.TryParse(carInfo[2],out weigth))
                {
                    car = new Car(carInfo[0], engine, weigth);
                }
                else
                {
                    car = new Car(carInfo[0], engine, carInfo[2]);
                }
                carsList.Add(car);
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.model}:");
                Console.WriteLine($"  {car.engine.model}:");
                Console.WriteLine($"    Power: {car.engine.power}");
                Console.WriteLine("    Displacement: {0}",car.engine.displacement== -1? @"n/a" : car.engine.displacement.ToString());
                Console.WriteLine($"    Efficiency: {car.engine.efficiency}");
                Console.WriteLine("  Weight: {0}",car.weight==-1 ? @"n/a" : car.weight.ToString());
                Console.WriteLine($"  Color: {car.color}");
            }

        }
    }
}
