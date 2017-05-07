using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BoxOfString
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            Box<int> boxInt = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                //StringGeneric();
                //IntGeneric();
            }

            //SwapStrings(n, box);
            SwapIntegers(n, boxInt);
        }

        private static void SwapIntegers(int n, Box<int> boxInt)
        {
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                boxInt.InsertItems(input);
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            boxInt.Swap(indexes[0], indexes[1]);
            boxInt.PrintElements();
        }

        private static void SwapStrings(int n, Box<string> box)
        {
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.InsertItems(input);
            }
            string[] indexes = Console.ReadLine().Split();

            int indexA = int.Parse(indexes[0]);
            int indexB = int.Parse(indexes[1]);

            box.Swap(indexA, indexB);

            box.PrintElements();
        }

        private static void IntGeneric()
        {
            int input = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            box.Template = input;
            Console.WriteLine(box.ToString());
        }

        private static void StringGeneric()
        {
            string input = Console.ReadLine();
            Box<string> box = new Box<string>();
            box.Template = input;
            Console.WriteLine(box.ToString());
        }

    }
}
