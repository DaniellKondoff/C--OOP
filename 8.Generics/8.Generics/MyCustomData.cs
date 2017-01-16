using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Generics
{
    class MyCustomData<T> : IReadOnlyData<T>
    {
        private List<T> data;

        public MyCustomData()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public void SomeMethod(T first,T second)
        {

        }

        //indexator

        public T this[int index]
        {
            get { return this.data[index]; }
        }

         
    }
}
