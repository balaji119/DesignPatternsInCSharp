using System;

namespace DesignPatternsInCSharp.Observer.DotNet
{
    class DataSubscriber2 : IObserver<Sourse>
    {
        private IDisposable unsubscriber;
        public virtual void Subscribe(IObservable<Sourse> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine("Subscriber 2: Complete");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Subscriber 2: "+ error.Message);
        }

        public void OnNext(Sourse value)
        {
            Console.WriteLine($"Subscriber 2: Got the data {value.Data}");
        }
    }
}
