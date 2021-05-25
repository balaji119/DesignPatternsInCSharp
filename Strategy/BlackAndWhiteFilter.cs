using System;

namespace DesignPatternsInCSharp.Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string filename)
        {
            Console.WriteLine($"Black and White filtetr applied to {filename}");
        }
    }
}
