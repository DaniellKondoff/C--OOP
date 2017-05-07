using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<ISerial> allModels = new List<ISerial>();

            while (input[0]!="End")
            {
                if (input.Length==3)
                {
                    var citizen = new Citizen()
                    {
                        Name = input[0],
                        Age = int.Parse(input[1]),
                        Id = input[2]
                    };
                    allModels.Add(citizen);
                }
                else if (input.Length==2)
                {
                    var robot = new Robot()
                    {
                        Model = input[0],
                        Id = input[1]
                    };
                    allModels.Add(robot);
                }
                input = Console.ReadLine().Split(' ');
            }

            string numberCheck = Console.ReadLine();

            foreach (var model in allModels)
            {
                if (model.Id.EndsWith(numberCheck))
                {
                    Console.WriteLine(model.Id);
                }
            }
        }
    }
}
