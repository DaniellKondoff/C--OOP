using System;


namespace _04.NumnerInReversedOrder
{
    public class DecimalNumber
    {
        public double number;
        public DecimalNumber(double number)
        {
            this.number = number;
        }

        public double ReverseNumber(double number)
        {
            return double.Parse(ReverseString(number.ToString()));
        }

        string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
    public class NumReversed
    {
       public  static void Main()
        {
            double numInput = Double.Parse(Console.ReadLine());
            DecimalNumber decNumber = new DecimalNumber(numInput);

            Console.WriteLine(decNumber.ReverseNumber(numInput));
        }
    }
}
