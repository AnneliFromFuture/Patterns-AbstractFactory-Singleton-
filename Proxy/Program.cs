using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensor = new Sensor("sensor1");
            
            var actuator = new Actuator("actuator1");

            Console.WriteLine(sensor.GetData());
            Console.WriteLine(actuator.GetData());

            var detector = new ProxyDetector("proxy1");
            Sensor s = null;
            detector.SetDetector(s);

            Console.WriteLine(detector.GetData());

            Console.ReadKey();
        }
    }
}
