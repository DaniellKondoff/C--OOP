using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name,int age,string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person otherPerson)
        {
            var nameCompere = this.Name.CompareTo(otherPerson.Name);
            var ageCompera = this.Age.CompareTo(otherPerson.Age);
            var townCompare = this.Town.CompareTo(otherPerson.Town);

            if (nameCompere == 0 && ageCompera==0 && townCompare==0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
