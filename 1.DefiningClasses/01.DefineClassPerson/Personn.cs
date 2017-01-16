using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClassPerson
{
    public class Person
    {
        public string name;
        public int age;
    }



    public class Personn
    {
        public static void Main()
        {

            var people = new Person()
            {
                name="Gosho",
                age=20
            };
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);


        }
    }
}
