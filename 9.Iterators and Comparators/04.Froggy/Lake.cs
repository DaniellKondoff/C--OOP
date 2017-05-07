using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    public class Lake :IEnumerable<int>
    {

        private List<int> colletion;

        public Lake(List<int> numberColelction)
        {
            this.colletion = numberColelction;
        }

        public IEnumerator<int> GetEnumerator()
        {

            return new CustomEnumerator(this.colletion);
            //for (int i = 0; i < this.colletion.Count; i+=2)
            //{
            //    yield return this.colletion[i];
            //}

            //int lastIndex = 0;
            //if (this.colletion.Count%2==0)
            //{
            //    lastIndex = this.colletion.Count - 1;
            //}
            //else
            //{
            //    lastIndex = this.colletion.Count - 2;
            //}

            //for (int i = lastIndex; i >= 0; i-=2)
            //{
            //        yield return this.colletion[i];               
            //}
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
