using System;

namespace DesignPatternsInCSharp.Observer.PullStyle
{
    public class Observer3 : IObserverPull
    {
        private readonly DataSoursePull dataSourse;

        public Observer3(DataSoursePull dataSourse)
        {
            this.dataSourse = dataSourse;
        }

        public void Update()
        {
            Console.WriteLine($"Observser 3 updated with value: {dataSourse.Data}");
        }
    }
}
