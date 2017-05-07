using _06.Birthday.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Birthday
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IBirthdate> birthdates = new List<IBirthdate>();

            while (input!="End")
            {
                string[] commands = input.Split(' ');
                if (commands[0]=="Citizen")
                {
                    string name = commands[1];
                    int age = int.Parse(commands[2]);
                    string id = commands[3];
                    DateTime date = DateTime.ParseExact(commands[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Human human = new Human(name, age, id, date);
                    birthdates.Add(human);
                }
                else if (commands[0] == "Pet")
                {
                    string name = commands[1];
                    DateTime date = DateTime.ParseExact(commands[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Pet pet = new Pet(name, date);
                    birthdates.Add(pet);
                }

                input = Console.ReadLine();
            }

            string checkDate = Console.ReadLine();
            
            foreach (var date in birthdates)
            {
                if (date.BirthDate.Year.ToString()==checkDate)
                {
                    Console.WriteLine(date.BirthDate.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
