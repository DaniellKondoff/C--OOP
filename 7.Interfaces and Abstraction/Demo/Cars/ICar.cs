using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Cars
{
    public interface ICar
    {
        string Model { get; }
        void Start();
        void Stop();
    }
}
