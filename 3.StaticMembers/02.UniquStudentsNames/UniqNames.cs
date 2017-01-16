using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UniquStudentsNames
{
    public class Student
    {
        public string name;
        public static HashSet<String> uniqueNames;

        public Student(string name)
        {
            this.name = name;
        }

        static Student()
        {
            uniqueNames =new HashSet<String>();
        }
    }
    class UniqNames
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            while(name != "End")
            {
                Student student = new Student(name);
                Student.uniqueNames.Add(student.name);
                name = Console.ReadLine();
            }
            Console.WriteLine(Student.uniqueNames.Count);
        }
    }
}
