using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BasicMath
{
    public class MathUtil
    {
        public static void Sum(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine("{0:f2}",sum);
        }
        public static void Multiply(double a, double b)
        {
            double multiply = a * b;
            Console.WriteLine("{0:f2}", multiply);
        }
        public static void Subtract(double a, double b)
        {
            double subtract = a - b;
            Console.WriteLine("{0:f2}", subtract);
        }

        public static void Divide(double devident, double devider)
        {
            double divide = devident / devider;
            Console.WriteLine("{0:f2}", divide);
        }
        public static void Percentage(double totalNum, double percent)
        {
            percent = percent / 100;
            double percentage = totalNum * percent;
            Console.WriteLine("{0:f2}", percentage);
        }
    }
   public class BasicMath
    {
       public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            while( !input.Contains("End"))
            {
                string cmd = input[0];
                double a = double.Parse(input[1]);
                double b = double.Parse(input[2]);
                switch (cmd)
                {
                    case "Sum":
                        MathUtil.Sum(a, b);
                        break;
                    case "Subtract":
                        MathUtil.Subtract(a, b);
                        break;
                    case "Multiply":
                        MathUtil.Multiply(a, b);
                        break;
                    case "Divide":
                        MathUtil.Divide(a, b);
                        break;
                    case "Percentage":
                        MathUtil.Percentage(a, b);
                        break;
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
