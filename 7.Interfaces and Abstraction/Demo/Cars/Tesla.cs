using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Cars
{
    public class Tesla : IElectricalCar
    {
        public string Model
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int numberOfBattery
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
