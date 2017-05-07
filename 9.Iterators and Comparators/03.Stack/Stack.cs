using System;
using System.Collections;
using System.Collections.Generic;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public Stack()
        {
            this.collection = new List<T>();
        }

        public void Push(T[] elements)
        {
            foreach (var element in elements)
            {
                this.collection.Add(element);
            }
        }

        public void Pop()
        {
            if (this.collection.Count==0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                this.collection.RemoveAt(this.collection.Count - 1);
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
