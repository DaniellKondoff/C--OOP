using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Interfaces_and_Abstraction.Store
{
    public class Implementator : IFirst, ISecond
    {
        public string Name()
        {
            return "Test";
        }

        int ISecond.Name()
        {
            return 0;
        }
    }
}
