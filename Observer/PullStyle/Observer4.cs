using System;

namespace DesignPatternsInCSharp.Observer.PullStyle
{
    public class Observer4 : IObserverPull
    {
        private readonly DataSoursePull dataSourse;

        public Observer4(DataSoursePull dataSourse)
        {
            this.dataSourse = dataSourse;
        }

        public void Update()
        {
            Console.WriteLine($"Observser 4 updated with value: {dataSourse.Data}");
        }
    }
}
