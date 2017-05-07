using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountMethodDoubles
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(input);
                boxes.Add(box);
            }

            Box<double> comparableBox = new Box<double>(double.Parse(Console.ReadLine()));

            int result = CompareElements(boxes, comparableBox);
            Console.WriteLine(result);
        }

        public static int CompareElements<T>(List<Box<T>> boxes,Box<T> comparableBox)
            where T : IComparable<T>
        {
            int count = boxes.Count(b => b.Template.CompareTo(comparableBox.Template) > 0);
            return count;
        }
    }
}
