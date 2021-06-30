using DesignPatternsInCSharp.Command;
using DesignPatternsInCSharp.Command.Fx;
using DesignPatternsInCSharp.Iterator;
using DesignPatternsInCSharp.Observer.PullStyle;
using DesignPatternsInCSharp.Observer.PushStyle;
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

            // Command pattern test
            Console.WriteLine("\nCommand Pattern Test");
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            button.Click();

            // Ovserver pattern test
            // Push style
            var dataSourse = new DataSourse();
            var observer1 = new Observer1();
            var observer2 = new Observer2();
            dataSourse.Attach(observer1);
            dataSourse.Attach(observer2);
            dataSourse.Data = 2;
            // Pull style
            var dsp = new DataSoursePull();
            var ob3 = new Observer3(dsp);
            var ob4 = new Observer4(dsp);
            dsp.Attach(ob3);
            dsp.Attach(ob4);
            dsp.Data = 4;

        }
    }
}
