using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Database
{
    public class Database
    {
        private const int DefaultCapacity = 16;
        private int[] elements;
        private int currentIndex;

        public Database(IEnumerable<int> elements)
        {
            this.elements = elements.ToArray();
        }

        public int[] Elements
        {
            get
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < this.currentIndex; i++)
                {
                    numbers.Add(elements[i]);
                }

                return numbers.ToArray();
            }
            private set
            {
                if (value.Length > 16 || value.Length<1)
                {
                    throw new InvalidOperationException("Given collection is bigger/lesser than specified");
                }

                this.elements = new int[DefaultCapacity];
                int bufferIndex = 0;

                foreach (var element in value)
                {
                    this.elements[bufferIndex++] = element;
                }

                this.currentIndex = value.Length;
            }
        }

        public int Capacity { get { return DefaultCapacity; } }

        public int Count { get { return currentIndex; } }

        public void Add(int element)
        {
            if (this.currentIndex==DefaultCapacity)
            {
                throw new InvalidOperationException("Cannod add more elements in the collection");
            }
            this.elements[currentIndex] = element;
            currentIndex++;
        }

        public void Remove()
        {
            if (this.currentIndex==0)
            {
                throw new InvalidOperationException("Cannot remove element from empty DB");
            }

            this.elements[currentIndex] = default(int);
            currentIndex--;
        }
    }
}
