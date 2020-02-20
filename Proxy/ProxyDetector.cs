using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxyDetector : Detector
    {
        private Detector _detector;

        public ProxyDetector(string name) : base(name)
        {

        }

        public void SetDetector(Detector detector)
        {
            _detector = detector;
        }

        public override string GetData()
        {
            if (_detector == null)
                return "proxy detector";
            return _detector.GetData();
        }
    }
}
