using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _07.ImmutableList
{
    public class ImmutableList
    {
        public List<double> collection;

        public ImmutableList(List<double> collection=null)
        {
            if (collection == null)
            {
                this.collection = new List<double>();
            }
            else
            {
                this.collection = collection;
            }
        }  

        public ImmutableList Get()
        {
            List<double> newColection = new List<double>(this.collection);
            var newImutable = new ImmutableList(newColection);
            return newImutable;
        }
    }
    public class ImmutableLisst
    {
        public static void Main()
        {
            Type immutableList = typeof(ImmutableList);
            FieldInfo[] fields = immutableList.GetFields();
            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(methods[0].ReturnType.Name);
            }

        }
    }
}
