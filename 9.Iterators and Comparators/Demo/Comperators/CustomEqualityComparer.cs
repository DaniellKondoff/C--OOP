using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Comperators
{
    public class CustomEqualityComparer : IEqualityComparer<int>
    {
        public bool Equals(int x, int y)
        {
            return x != y;
        }

        public int GetHashCode(int obj)
        {
            throw new NotImplementedException();
        }
    }
}
