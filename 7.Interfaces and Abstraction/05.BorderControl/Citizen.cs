using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BorderControl
{
    class Citizen : ICitizen,ISerial
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Id { get; set; }
      
    }
}
