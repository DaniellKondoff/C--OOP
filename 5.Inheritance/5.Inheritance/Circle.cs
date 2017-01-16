using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Inheritance
{
    class Circle : Shape
    {
        public Circle(int x, int y, double radius) : base(x, y)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

    }
}
