using System;

namespace DesignPatternsInCSharp.Template
{
    class BalanceCheckTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Balance check");
        }
    }
}
