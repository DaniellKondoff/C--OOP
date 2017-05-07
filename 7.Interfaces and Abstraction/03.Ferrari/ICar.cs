using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferraries
{
    public interface ICar
    {
        string DriverName { get; set; }

        string Model { get; set; }

        string Brakes();

        string Gas();
    }
}
