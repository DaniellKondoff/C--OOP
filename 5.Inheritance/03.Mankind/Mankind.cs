using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind
{
    class Mankind
    {
        static void Main()
        {
            try
            {
                String[] firstLine = Console.ReadLine().Split(' ');
                String[] secondLine = Console.ReadLine().Split(' ');

                Student student = new Student(firstLine[0],firstLine[1],firstLine[2]);
                Worker worker = new Worker(secondLine[0], secondLine[1], double.Parse(secondLine[2]), double.Parse(secondLine[3]));

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
            

        }
    }
}
