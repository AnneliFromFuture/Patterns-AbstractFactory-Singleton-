using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Actuator : Detector
    {
        private string _name;

        public Actuator(string name) : base(name)
        {
            _name = name;
        }

        public override string GetData()
        {
            return _name;
        }
    }
}
