using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    public class CustomEnumerator : IEnumerator<int>
    {
        private List<int> stones;
        int index = -1;
        public CustomEnumerator(List<int> stones)
        {
            this.stones = stones;
        }

        public int Current
        {
            get
            {
                return this.stones[this.index];
            }
        }

        object IEnumerator.Current => this.Current;
        

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++index < this.stones.Count;
        }

        public void Reset()
        {
        }
    }
}
