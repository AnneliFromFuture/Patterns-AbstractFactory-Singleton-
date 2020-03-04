namespace Observer
{
    interface IObservable
    {
        void AttachStudent(IObserver observer);

        void DetachStudent(IObserver observer);

        void NotifyAboutDeadline(string deadlineMessage);
    }
}
