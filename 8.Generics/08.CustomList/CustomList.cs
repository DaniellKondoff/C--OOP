using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CustomList
{
    public class CustomList<T>
        where T : IComparable<T>
    {
        private List<T> elements;

        public CustomList()
        {
            this.elements = new List<T>();
        }

        public int Count => this.elements.Count;

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove(int index)
        {
            T elementOfIndex = this.elements[index];
            this.elements.RemoveAt(index);
            return elementOfIndex;
        }

        public bool Contains(T element)
        {
            if (this.elements.Any(e=>e.Equals(element)))
            {
                return true;
            }
            return false;
        }

        public void Swap(int indexA,int indexB)
        {
            T firstElement = this.elements[indexA];
            T secondElement = this.elements[indexB];
            this.elements[indexA] = secondElement;
            this.elements[indexB] = firstElement;
        }

        public int CountGreaterThan(T element)
        {
            int count = this.elements.Count(e => e.CompareTo(element) > 0);
            return count;
        }

        public T Max()
        {
            T maxElement = this.elements.Max();
            return maxElement;
        }

        public T Min()
        {
            T minElement = this.elements.Min();
            return minElement;
        }

        public void Print()
        {
            foreach (var el in this.elements)
            {
                Console.WriteLine(el);
            }
        }

        
    }
}
