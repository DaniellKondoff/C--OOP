using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private T template;

        public Box()
            : this(default(T))
        {

        }

        public Box(T template)
        {
            this.Template = template;
        }

        public T Template
        {
            get
            {
                return this.template;
            }
            set
            {
                template = value;
            }
        }
    }
}
