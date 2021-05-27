using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsInCSharp.Command.Fx;

namespace DesignPatternsInCSharp.Command
{
    class AddCustomerCommand : ICommand
    {
        private readonly CustomerService customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void Execute()
        {
            customerService.AddCustomer();
        }
    }
}
