using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public abstract class Detector
    {
        private string _name;

        public Detector(string name)
        {
            _name = name;
        }

        public virtual string GetData()
        {
            return _name;
        }
    }
}
