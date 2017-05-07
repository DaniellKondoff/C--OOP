using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferraries
{
    public class Ferrari : ICar
    {
        string model = "488-Spider";
        public Ferrari(string driverName)
        {          
            this.DriverName = driverName;
            this.Model = model;
        }
        public string DriverName { get; set; }


        public string Model { get; set; }


        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }
    }
}
