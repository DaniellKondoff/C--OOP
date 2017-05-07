using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestAttr
{
    public class MyExpectedExceptionAttribute : Attribute
    {
        public MyExpectedExceptionAttribute()
        {

        }

        public MyExpectedExceptionAttribute(Type expectedException)
        {
            this.ExpectedException = expectedException;
        }

        public Type ExpectedException { get; private set; }
    }
}
