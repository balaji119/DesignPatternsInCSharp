using DesignPatternsInCSharp.Iterator;
using DesignPatternsInCSharp.State;
using System;

namespace DesignPatternsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // State pattern test.
            var canvas = new Canvas
            {
                CurrentTool = new SelectionTool()
            };
            canvas.MouseDown();
            canvas.MouseUp();

            // Iterator pattern test.
            var browseHistory = new BrowseHistory();
            browseHistory.Push("url1");
            browseHistory.Push("url2");
            var iterator = browseHistory.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetCurrent());
                iterator.Next();
            };
        }
    }
}
