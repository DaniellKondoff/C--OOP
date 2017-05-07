using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListIterator
{
    public class ListIterator<T> : IEnumerator<T>,IEnumerable<T>
    {
        private List<T> collection;
        private int currentIndex = 0;
        public ListIterator(List<T> collection)
        {
            this.collection = collection;
            currentIndex = 0;
        }

        public T Current
        {
            get
            {
                return this.collection[currentIndex];
            }
        }

        public int Count
        {
            get
            {
                return this.collection.Count();
            }

        }
        object IEnumerator.Current => this.Current;
       
        public bool MoveNext()
        {
            this.currentIndex++;
            if (currentIndex>=this.collection.Count)
            {
                return false;
            }
            return true;
        }

        public bool hasNext()
        {
            return this.currentIndex < this.collection.Count - 1;
        }

        public void Dispose()
        {
            
        }

        public void Reset()
        {
            
        }

        public void Print()
        {
            if (this.collection.Count==0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.collection[currentIndex]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
