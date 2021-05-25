﻿using System;

namespace DesignPatternsInCSharp.Strategy
{
    public class ImageStorage
    {
        public void Store(string filename, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(filename);
            filter.Apply(filename);
            Console.WriteLine($"Stored file: {filename}");
        }
    }
}
