using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Iterator
{
    public class ListIteretor
    {
        private List<string> collection;
        private int currentIndex = 0;

        public ListIteretor(List<string> collection)
        {
            this.Collection = collection;
        }
        public ListIteretor()
        {
            
        }
        public List<string> Collection
        {
            get
            {
                return this.collection;
            }
            set
            {
                if (value ==null)
                {
                    throw new ArgumentNullException("Collection cannot be empty or null");
                }
                this.collection = value;
            }
        }

        public int CurrentIndex { get { return this.currentIndex; } }

        public bool Move()
        {
            if (this.currentIndex+1==this.collection.Count)
            {
                return false;
            }
            this.currentIndex++;
            return true;
        }

        public bool HasNext()
        {
            if (this.currentIndex + 1 == this.collection.Count)
            {
                return false;
            }
            return true;
        }

        public string Print()
        {
            if (this.collection.Count<1)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            return this.collection[this.currentIndex];
        }
    }
}
