using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Inheritance
{
    public  class Book
    {
        public string name;

        public Book(string name)
        {
            this.Name = name;
        }

        //public string Name => this.name;

        public string Name
        {
            get
            {
                return this.name;
            }
           private set
            {
                this.name = value;
            }
        }
    }
}
