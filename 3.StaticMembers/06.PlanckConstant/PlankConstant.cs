using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PlanckConstant
{
    public class Calculator
    {
        public const double PLANCK = 6.62606896e-34;
        public const double PI = 3.14159;

       public static void Calc()
        {
            Console.WriteLine((PLANCK)/(2*PI));
        }
    }
    public class PlankConstant
    {
      public  static void Main()
        {
            Calculator.Calc();
        }
    }
}
