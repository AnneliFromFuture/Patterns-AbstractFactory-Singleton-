using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory.Interfaces;

namespace Abstract_factory
{
    class Sensor : ISensor
    {
        public enum Sensors { Temperature, Wet, Luminosity }

        public Sensors SensorName { get; set; }

        public Sensor(Sensors name)
        {
            SensorName = name;
        }

        public void SendData()
        {
            //
        }
    }
}
