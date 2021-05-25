using System;

namespace DesignPatternsInCSharp.Strategy
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"{fileName} compressed using PNG");
        }
    }
}
