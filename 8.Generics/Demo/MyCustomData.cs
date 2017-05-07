using System.Collections.Generic;

namespace Demo
{
    public class MyCustomData<T> : IReadOnlyData<T>
    {
        private List<T> data;

        public MyCustomData()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;

        public T this[int index]
        {
            get
            {
                return this.data[index];
            }
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }


    }
}
