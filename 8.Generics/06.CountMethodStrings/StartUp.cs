using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountMethodStrings
{
    class StartUp
    {
        static void Main()
        {
            List<Box<string>> boxes = new List<Box<string>>();
            int boxCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < boxCount; i++)
            {
                string input = Console.ReadLine();
                boxes.Add(new Box<string>(input));
            }

            Box<string> comparableBox = new Box<string>(Console.ReadLine());

            int result = CampareElements(boxes, comparableBox);
            Console.WriteLine(result);
        }

        static int CampareElements<T>(List<Box<T>> boxes,Box<T> comparableBox)
            where T : IComparable<T>
        {
            int count = 0;
            foreach (var box in boxes)
            {
                if (box.Template.CompareTo(comparableBox.Template)>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
