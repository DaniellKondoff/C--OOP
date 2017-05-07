using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace _10.TirePressureMonitorSystem.Tests
{
    [TestClass]
    public class TirPressureTest
    {
        private Alarm alarm;
        //private Sensor sensor;

        [TestInitialize]
        public void Init()
        {
            var sensorMock = new Mock<Sensor>();
                
        }


    }
}
