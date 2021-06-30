using System;

namespace DesignPatternsInCSharp.Observer.PushStyle
{
    class Observer1 : IObserver
    {
        public void Update<T>(T val)
        {
            Console.WriteLine($"Observer 1 updated with value: {val}");
        }
    }
}
