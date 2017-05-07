using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrategyPattern
{
    public class PersonNameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var nameCompare = x.Name.Length.CompareTo(y.Name.Length);
            if (nameCompare!=0)
            {
                return nameCompare;
            }

            return x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
        }
    }
}
