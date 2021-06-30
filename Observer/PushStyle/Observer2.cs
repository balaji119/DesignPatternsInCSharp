using System;

namespace DesignPatternsInCSharp.Observer.PushStyle
{
    class Observer2 : IObserver
    {
        public void Update<T>(T val)
        {
            Console.WriteLine($"Observer 2 updated with value: {val}");
        }
    }
}
