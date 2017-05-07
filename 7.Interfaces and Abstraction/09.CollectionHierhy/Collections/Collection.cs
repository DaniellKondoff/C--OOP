using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CollectionHierhy.Collections
{
    public abstract class Collection
    {
        private List<string> elements;
        const int MAX_CAPACITY = 100;
        public Collection()
        {
            this.elements = new List<string>(MAX_CAPACITY);
        }

        public List<string> Elements { get { return elements; } }
    }
}
