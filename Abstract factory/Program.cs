using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory.ConcreteScenarios;
using Abstract_factory.Interfaces;

namespace Abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var scenario1 = new CleaningScenario();
            ConstructScenario(scenario1);

            var scenario2 = new StandardScenario();
            ConstructScenario(scenario2);

            var scenario3 = new CookingScenario();
            ConstructScenario(scenario3);
        }

        public static void ConstructScenario(IDetectorsFactory factory)
        {
            var place = factory.CreatePlace();
            var sensor = factory.CreateSensor();
            var signal = factory.CreateSignal();
        }
    }
}
