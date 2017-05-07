using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BorderControl
{
    class Robot : ISerial,IRobot
    {
        public string Id { get; set; }

        public string Model { get; set; }
        
    }
}
