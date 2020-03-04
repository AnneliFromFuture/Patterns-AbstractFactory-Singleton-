using System;

namespace Observer
{
    class SecondStudent : IObserver
    {
        public void GetDeadlineData(string data)
        {
            Console.WriteLine("\nsecond student received message: " + data);
        }
    }
}
