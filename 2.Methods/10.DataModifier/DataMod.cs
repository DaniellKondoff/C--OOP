using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DataModifierr
{
    public class DateModifier
    {
        public void DataResult(string data1, string data2)
        {
            DateTime time1 = DateTime.Parse(data1);
            DateTime time2 = DateTime.Parse(data2);
            var result = Math.Abs((time1 - time2).TotalDays);
            Console.WriteLine(result);
        }
    }
   public class DataMod
    {
       public static void Main()
        {
            string d1 = Console.ReadLine();
            string d2 = Console.ReadLine();
            DateModifier d = new DateModifier();
            d.DataResult(d1, d2);
        }
    }
}
