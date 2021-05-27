using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Command.Fx
{
    public class Button
    {
        private readonly ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public int Label { get; set; }

        public void Click()
        {
            command.Execute();
        }
    }
}
