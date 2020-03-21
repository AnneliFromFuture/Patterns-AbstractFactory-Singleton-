using System;
using System.Collections.Generic;

namespace Observer
{
    class StudyOffice : IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void AttachStudent(IObserver observer)
        {
            Console.WriteLine("\nSubject: Attached an observer.");
            _observers.Add(observer);
        }

        public void DetachStudent(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("\nSubject: Detached an observer.");
        }

        public void NotifyAboutDeadline(string deadlineMessage)
        {
            Console.WriteLine("\nSubject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.GetDeadlineData(deadlineMessage);
            }
        }
    }
}
