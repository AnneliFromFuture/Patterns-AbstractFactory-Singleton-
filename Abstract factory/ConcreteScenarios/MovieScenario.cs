using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory.Interfaces;

namespace Abstract_factory.ConcreteScenarios
{
    public class MovieScenario : IDetectorsFactory
    {
        public ISensor CreateSensor()
        {
            return new Sensor(Sensor.Sensors.Luminosity);
        }

        public IPlace CreatePlace()
        {
            return new Place(Place.Places.Room);
        }

        public ISignal CreateSignal()
        {
            return new Signal(Signal.Signals.Low);
        }
    }
}
