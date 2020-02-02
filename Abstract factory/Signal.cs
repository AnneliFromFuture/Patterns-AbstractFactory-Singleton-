using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory.Interfaces;

namespace Abstract_factory
{
    class Signal : ISignal
    {
        public enum Signals { Low, Norm, More }

        public Signals SignalState { get; set; }

        public Signal(Signals signalState)
        {
            SignalState = signalState;
        }

        public bool IsSignalCritical()
        {
            if (SignalState == Signals.Norm)
                return false;
            return true;
        }
    }
}
