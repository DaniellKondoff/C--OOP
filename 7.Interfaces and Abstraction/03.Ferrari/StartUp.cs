using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferraries
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();
            ICar ferrari = new Ferrari(driverName);

            Console.WriteLine($"{ferrari.Model}/{ferrari.Brakes()}/{ferrari.Gas()}/{ferrari.DriverName}");

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }            
        }
    }
}
