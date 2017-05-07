using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public static class Calculator
    {
        public static int Sum(int first,int second)
        {
            return first + second;
        }

        public static int Product(int first, int second)
        {
            return first * second;
        }

        public static decimal Divide(decimal first, decimal second)
        {
            if (second==0)
            {
                throw new DivideByZeroException();
            }
            return first / second;
        }
    }
}
