using Abstract_factory.Interfaces;
using System;

namespace Abstract_factory.ConcreteScenarios
{
    public class CleaningScenario : IDetectorsFactory
    {
        public ISensor CreateSensor()
        {
            return new Sensor(Sensor.Sensors.Wet);
        }

        public IPlace CreatePlace()
        {
            return new Place(Place.Places.Garage);
        }

        public ISignal CreateSignal()
        {
            return new Signal(Signal.Signals.More);
        }
    }
}
