using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Generics
{
    class Demo
    {
        static void Main(string[] args)
        {
            var data = new MyCustomData<int>();

            data.Add(5);
            System.Console.WriteLine(data.Count);

            var result = data[0];
            System.Console.WriteLine(result);

            var cat = new Cat(" ");

            cat.Eat<int>(1);
            cat.Eat(1);

            var listOfNUmbers = new List<int>();
            listOfNUmbers.Where<int>(x => x == 1);
            listOfNUmbers.Where(x => x == 1);


            var numbers = CreateList<int>(10, 5);
            var text = CreateList<string>("Pesho", 50);

            System.Console.WriteLine(text.Count);

            var numberss = CreateInstance<int>();
             //cat =CreateInstance<Cat>();
        }

        static List<T> CreateList<T>(T value, int count)
        {
            var list = new List<T>();

            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }

            return list;
        }

        public static T CreateInstance<T>(params object[] args)
         
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }
    }
}
