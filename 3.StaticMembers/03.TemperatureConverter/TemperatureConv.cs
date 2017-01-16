using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TemperatureConverter
{
    class TemperatureConv
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            while(input[0] != "End")
            {
                TempConvertor(int.Parse(input[0]), input[1]);
                input = Console.ReadLine().Split();
            }

        }

        public static void TempConvertor(int temp, string unit)
        {
            double result = 0;
            if(unit== "Celsius")
            {
                result = (temp * 1.8) + 32;
                Console.WriteLine("{0:f2} Fahrenheit", result);
            }
            else
            {
                result = (temp - 32) / 1.8;
                Console.WriteLine("{0:f2} Celsius", result);
            }

        }
    }
}
