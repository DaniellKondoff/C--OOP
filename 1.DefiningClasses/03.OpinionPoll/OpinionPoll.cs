using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OpinionPoll
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => this.name;

        public int Age
        {
            get { return this.age; }
        }
    }

    public class OpinionPoll
    {
       public static void Main()
        {
            //int numberOfPeople = int.Parse(Console.ReadLine());

            //var people = new List<Person>();

            //for (int i = 0; i < numberOfPeople; i++)
            //{
            //    var personInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    var person = new Person(personInfo[0],int.Parse(personInfo[1]));

            //    people.Add(person);
            //}

            //people
            //    .Where(p => p.Age > 30)
            //    .OrderBy(p => p.Name)
            //    .ToList()
            //    .ForEach(p=>Console.WriteLine($"{p.Name} - {p.Age}"));



            int numberOfPeople = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);
            }

            people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));

        }
    }
}
