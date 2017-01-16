using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PrdoublePeople
{
    public class Person
    {
        public string name;
        public double age;
        public string occupation;
        public Person(string name,double age,string occupation)
        {
            this.name = name;
            this.age = age;
            this.occupation = occupation;
        }
    }
    public class PrdoublePeople
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            List<Person> persons = new List<Person>();
            while(input[0]!="END")
            {
                Person person = new Person(input[0], double.Parse(input[1]), input[2]);
                persons.Add(person);
                input = Console.ReadLine().Split();
            }

            persons.OrderBy(p => p.age).ToList().ForEach(p=>Console.WriteLine($"{p.name} - age: {p.age}, occupation: {p.occupation}"));
        }
    }
}
