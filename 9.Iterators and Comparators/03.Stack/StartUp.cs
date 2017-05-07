using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> myList = new Stack<int>();
            //int[] elements = Console.ReadLine().Split( new string[] { ","," " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[] input = Console.ReadLine().Split(new string[] { ","," "},StringSplitOptions.RemoveEmptyEntries);

            while (input[0]!="END")
            {
                switch (input[0])
                {
                    case "Push":
                        int[] elements = input.Skip(1).Select(int.Parse).ToArray();
                        myList.Push(elements);
                        break;
                    case "Pop":
                        myList.Pop();
                        break;
                }
                input= Console.ReadLine().Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            }

            
            for (int i = 0; i < 2; i++)
            {
                foreach (var element in myList.Reverse())
                {
                    Console.WriteLine(element);
                }
            }

            
           
        }
    }
}
