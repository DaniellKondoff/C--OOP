using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    class StartUp
    {
        static void Main()
        {
            List<int> inputNumbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
        

            Lake collection = new Lake(inputNumbers);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(string.Join(", ",collection));
        }
    }
}
