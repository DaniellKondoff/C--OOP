using _09.CollectionHierhy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CollectionHierhy.Collections
{
    public class MyList : Collection, ICountable
    {
        public int Used
        {
            get
            {
                return base.Elements.Count;
            }
        }


        public int Add(string element)
        {
            base.Elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string element = base.Elements[0];
            base.Elements.RemoveAt(0);
            return element;
        }
    }
}
