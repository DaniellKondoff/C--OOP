using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BoxOfString
{
    public class Box<T>
    {
        private T template;
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
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


        public override string ToString()
        {
            return $"{this.Template.GetType().FullName}: {this.Template}";
        }

        public void InsertItems(T obj)
        {
            this.data.Add(obj);
        }

        public void Swap(int a, int b)
        {
            T firstElement = this.data[a];
            T secondElement = this.data[b];
            this.data[a] = secondElement;
            this.data[b] = firstElement;
        }

        public void PrintElements()
        {
            foreach (var item in this.data)
            {
                Console.WriteLine($"{item.GetType().FullName}: {item.ToString()}");
            }
        }
    }
}
