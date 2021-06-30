using System;
using System.Collections.Generic;

namespace DesignPatternsInCSharp.Observer.DotNet
{
    public class DataProvider : IObservable<Sourse>
    {
        private List<IObserver<Sourse>> observers = new List<IObserver<Sourse>>();

        public IDisposable Subscribe(IObserver<Sourse> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsubscriber(observers, observer);
        }

        public void TrackData(Sourse? sourse)
        {
            foreach (var observer in observers)
            {
                if (!sourse.HasValue)
                    observer.OnError(new Exception("No data found"));
                else
                    observer.OnNext(sourse.Value);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }

        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<Sourse>> observers;
            private readonly IObserver<Sourse> observer;

            public Unsubscriber(List<IObserver<Sourse>> observers, IObserver<Sourse> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if(observer != null && observers.Contains(observer))
                {
                    observers.Remove(observer);
                }
            }
        }
    }
}
