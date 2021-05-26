﻿using System;

namespace DesignPatternsInCSharp.Template
{
    public class TransferMoneyTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}
