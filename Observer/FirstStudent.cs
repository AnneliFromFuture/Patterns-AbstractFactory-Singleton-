using System;

namespace Observer
{
    class FirstStudent : IObserver
    {
        public void GetDeadlineData(string data)
        {
            Console.WriteLine("\nfirst student received message: " + data);
        }
    }
}
