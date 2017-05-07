using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBox
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.value = 123;
            Console.WriteLine(box.ToString());

            Box<string> boxString = new Box<string>();
            boxString.value = "life in a box";
            Console.WriteLine(boxString.ToString());
        }
    }
}
