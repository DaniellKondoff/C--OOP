using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_Digit_Name
{
    public class Number
    {
        public double number;

        public Number(double number)
        {
            this.number = number;
        }

        public void englishNameLastDigit()
        {
            switch (this.number % 10)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }
        }
        public double reverse()
        {
            double num = this.number;
            double result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
    class LastDigitName
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            Number num = new Number(n);

            num.englishNameLastDigit();
            Console.WriteLine(num.reverse());

        }
    }
}
