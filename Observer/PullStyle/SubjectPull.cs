using System.Collections.Generic;

namespace DesignPatternsInCSharp.Observer.PullStyle
{
    public abstract class SubjectPull
    {
        private List<IObserverPull> observers = new List<IObserverPull>();

        public void Attach(IObserverPull observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserverPull observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
