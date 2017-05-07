using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CustomList
{
    public class Sorter
    {
        public static void Sort<T>(CustomList<T> elements) where 
            T : IComparable<T>
        {
            for (int i = 0; i < elements.Count; i++)
            {
                T currentElement = elements[i];

                for (int j = i+1; j < elements.Count; j++)
                {
                    T nextElement = elements[j];

                    if (currentElement.CompareTo(nextElement)>0)
                    {
                        elements.Swap(i, j);
                    }
                }
            }
        }
    }
}
