using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListIterator
{
    class StartUp
    {
        static void Main()
        {
            ListIterator<string> collection = null;

            string[] input = Console.ReadLine().Split();
            int counter = 1;

            while (input[0] != "END")
            {
                if (counter>=100)
                {
                    break;
                }
                switch (input[0])
                {
                    case "Create":
                        if (input.Length==1)
                        {
                            collection = new ListIterator<string>(new List<string>());
                        }
                        else
                        {
                            string[] lines = input.Skip(1).ToArray();
                            collection = new ListIterator<string>(new List<string>(lines));
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(collection.hasNext());
                        break;
                    case "Move":
                        Console.WriteLine(collection.MoveNext());
                        break;
                    case "Print":
                        collection.Print();
                        break;
                    case "PrintAll":
                        foreach (var element in collection)
                        {
                            Console.Write(element +" ");                           
                        }
                        Console.WriteLine();
                        break;
                }

                input = Console.ReadLine().Split();
                counter++;
            }
           
        }
    }
}
