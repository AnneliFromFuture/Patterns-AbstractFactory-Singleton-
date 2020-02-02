using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory;
using Abstract_factory.Interfaces;

namespace Abstract_factory.ConcreteScenarios
{
    public class CookingScenario : IDetectorsFactory
    {
        public ISensor CreateSensor()
        {
            return new Sensor(Sensor.Sensors.Temperature);
        }

        public IPlace CreatePlace()
        {
            return new Place(Place.Places.Kitchen);
        }

        public ISignal CreateSignal()
        {
            return new Signal(Signal.Signals.More);
        }
    }
}
