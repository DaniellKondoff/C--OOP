using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci
{
    public class Fib
    {
        public double start;
        public double end;
        public Fib(double start ,double end)
        {
            this.start = start;
            this.end = end;
        }

        public IEnumerable Fibo(double start, double end)
        {
            double firstMember = 1;
            double secondMember = 0;
            double result = 0;
            var output = new List<double>();
            for (double i = start; i <= end; i++)
            {
                if (end == 0 || end == 1)
                {
                    return firstMember;
                }
                else
                {
                    result = firstMember + secondMember;
                    output.Add(result);
                    firstMember = secondMember;
                    secondMember = result;
                    
                }
            }
            return output;
        }
    }
    public class Fibonaci
    {
        public static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            Fib fibNums = new Fib(firstNum, secondNum);
            fibNums.Fibo(firstNum, secondNum);
            Console.WriteLine(fibNums.Fibo(firstNum, secondNum));

        }
    }
}
