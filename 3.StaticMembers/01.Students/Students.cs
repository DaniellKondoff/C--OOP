using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students
{
    public class Students
    {
        public string name;
        public static int counter;

        public Students(string name)
        {
            this.name = name;
            ++counter;
        }
        static Students()
        {
            counter = 0;
        }
    }
    public class Studentss
    {
      public static void Main()
        {
            string name = Console.ReadLine();

            while(name != "End")
            {
                Students student = new Students(name);
                name = Console.ReadLine();
            }
            Console.WriteLine(Students.counter);
        }
    }
}
