using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string nameFirst,string nameLast,string facultyNumber) 
            : base(nameFirst,nameLast)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            private set
            {
                if(value.Length <5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format($"First Name: {this.NameFirst}"));
            sb.Append(Environment.NewLine);
            sb.Append(String.Format($"Last Name: {this.NameLast}"));
            sb.Append(Environment.NewLine);
            sb.Append(String.Format($"Faculty number: {this.FacultyNumber}"));

            return sb.ToString();
        }
    }
}
