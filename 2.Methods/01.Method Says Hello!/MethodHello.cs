using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _01.Method_Says_Hello_
{
    public class Person
    {
        public string personName;

        public Person(string personName)
        {
            this.personName = personName;
        }
        public string  SayHello()
        {
            return $"{this.personName} says \"Hello\"!";
        }
    }
    class MethodHello
    {
       
        static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] methods = personType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            if (fields.Length != 1 || methods.Length != 5)
            {
                throw new Exception();
            }

            string personName = Console.ReadLine();
            Person person = new Person(personName);

            Console.WriteLine(person.SayHello());

        
        }
    }
}
