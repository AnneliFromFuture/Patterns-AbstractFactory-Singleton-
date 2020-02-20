using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Sensor : Detector
    {
        private string _name;

        public Sensor(string name) : base(name)
        {
            _name = name;
        }

        public override string GetData()
        {
            return _name;
        }
    }
}
