using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ShapesVolume
{
    public class TriangularPrism
    {
        public double side;
        public double hight;
        public double lenght;

        public TriangularPrism(double side, double hight, double lenght)
        {
            this.side = side;
            this.hight = hight;
            this.lenght = lenght;
        }
    }

    public class Cube
    {
        public double sideLenght;
        public Cube(double sideLenght)
        {
            this.sideLenght = sideLenght;
        }
    }
    public class Cylinder
    {
        public double radius;
        public double height;
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
    }

    public class VolumeCalculator
    {
        public static double TriangularPrismVOlume(TriangularPrism triangularPrism)
        {
            return (0.5d * triangularPrism.hight*triangularPrism.lenght*triangularPrism.side);
        }
        public static double CubeVolume(Cube cube)
        {
            return (Math.Pow(cube.sideLenght, 3));
        }
        public static double CylinderVOlume(Cylinder cylinder)
        {
            return (Math.PI * Math.Pow(cylinder.radius, 2) * cylinder.height);
        }
    }
   public class ShapesVolume
    {
       public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            while (!input.Contains("End"))
            {
                string figyreType = input[0];
                switch (figyreType)
                {
                    case "Cube":
                        Cube cube = new Cube(double.Parse(input[1]));
                        Console.WriteLine("{0:f3}",VolumeCalculator.CubeVolume(cube));
                        break;
                    case "Cylinder":
                        Cylinder cylender = new Cylinder(double.Parse(input[1]), double.Parse(input[2]));
                        Console.WriteLine("{0:f3}",VolumeCalculator.CylinderVOlume(cylender));
                        break;
                    case "TrianglePrism":
                        TriangularPrism triangularPrism = new TriangularPrism(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        Console.WriteLine("{0:f3}",VolumeCalculator.TriangularPrismVOlume(triangularPrism));
                        break;
                }

              input = Console.ReadLine().Split();
            }
        }
    }
}
