using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class StartUp
    {
        public static void Main()
        {
            Type typeOfcat = new Cat().GetType();

            Console.WriteLine(typeOfcat.Name);
            Console.WriteLine(typeOfcat.FullName);
            Console.WriteLine(typeOfcat.Assembly.FullName);

            foreach (var prop in typeOfcat.GetProperties())
            {
                Console.WriteLine(prop.Name + " "+prop.PropertyType.Name);
            }
            Console.WriteLine(typeOfcat.BaseType.Name);
            var allInterfaces = typeOfcat.BaseType.GetInterfaces();
            Console.WriteLine();

            var baseType = typeOfcat.BaseType;

            //while (baseType != typeof(object))
            //{
            //    Console.WriteLine(baseType.Name);
            //}

            var assembly = Assembly.GetEntryAssembly().GetTypes();

            foreach (var item in assembly)
            {
                Console.WriteLine(item.Name);
            }

            var cat = (Cat)Activator.CreateInstance(typeof(Cat));
            

            var properties = typeOfcat.GetProperties();

        }
    }
}
