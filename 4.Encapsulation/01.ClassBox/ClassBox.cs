using System;
using System.Linq;
using System.Reflection;

namespace _01.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetLateralSurfaceArea()
        {
            return (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double GetSurfaceArea()
        {
            return (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double GetVolume()
        {
            return (this.length * this.width * this.height);
        }

    }
   public class ClassBox
    {
       public static void Main()
        {
            double l = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            Box box = new Box(l, h, w);

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            Console.WriteLine("Surface Area - {0:f2}", box.GetSurfaceArea());
            Console.WriteLine("Lateral Surface Area - {0:f2}", box.GetLateralSurfaceArea());
            Console.WriteLine("Volume - {0:f2}", box.GetVolume());

        }
    }
}
