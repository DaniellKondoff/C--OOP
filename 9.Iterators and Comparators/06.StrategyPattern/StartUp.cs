using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrategyPattern
{
    class StartUp
    {
        static void Main()
        {
            var sortedNameSet = new SortedSet<Person>(new PersonNameComparator());
            var sortedAgeSet = new SortedSet<Person>(new PersonAgeComparator());

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], int.Parse(input[1]));
                sortedNameSet.Add(person);
                sortedAgeSet.Add(person);
            }
            foreach (var person in sortedNameSet)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
            foreach (var person in sortedAgeSet)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
            
        }
    }
}
