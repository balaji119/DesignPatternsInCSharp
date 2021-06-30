using System.Collections.Generic;

namespace DesignPatternsInCSharp.Observer.PushStyle
{
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify<T>(T val)
        {
            foreach(var observer in observers)
            {
                observer.Update(val);
            }
        }
    }
}
