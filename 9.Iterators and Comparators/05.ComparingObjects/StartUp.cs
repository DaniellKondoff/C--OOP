using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Person> people = new List<Person>();

            while (input[0] != "END")
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];
                Person person = new Person(name, age, town);
                people.Add(person);
                input= Console.ReadLine().Split();
            }

            int n = int.Parse(Console.ReadLine());
                      
            int counter = 0;
            for (int i = n-1; i < people.Count(); i++)
            {
                if (people[i-1].CompareTo(people[i])==0)
                {
                    counter++;
                }
            }
            
            if (counter==0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                counter += 1;
                int difference = people.Count() - counter;
                Console.WriteLine($"{counter} {difference} {people.Count}");
            }
        }
    }
}
