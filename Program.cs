using DesignPatternsInCSharp.Iterator;
using DesignPatternsInCSharp.State;
using DesignPatternsInCSharp.Strategy;
using DesignPatternsInCSharp.Template;
using System;

namespace DesignPatternsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // State pattern test.
            Console.WriteLine("\nState Pattern Test");
            var canvas = new Canvas
            {
                CurrentTool = new SelectionTool()
            };
            canvas.MouseDown();
            canvas.MouseUp();

            // Iterator pattern test.
            Console.WriteLine("\nIterator Pattern Test");
            var browseHistory = new BrowseHistory();
            browseHistory.Push("url1");
            browseHistory.Push("url2");
            var iterator = browseHistory.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetCurrent());
                iterator.Next();
            };

            // Strategy pattern test
            Console.WriteLine("\nStrategy Pattern Test");
            var imageStorage = new ImageStorage();
            imageStorage.Store("file1", new PngCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("file1", new JpegCompressor(), new BlackAndWhiteFilter());
            Console.WriteLine("\n");

            // Template pattern test
            Console.WriteLine("\nTemplate Pattern Test");
            var trasferMoneyTask = new TransferMoneyTask();
            trasferMoneyTask.Execute();
        }
    }
}
