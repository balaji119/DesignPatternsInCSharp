using System;

namespace DesignPatternsInCSharp.Strategy
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"{fileName} compressed using JPEG");
        }
    }
}
