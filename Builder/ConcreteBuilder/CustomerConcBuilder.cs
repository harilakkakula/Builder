using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBuilder
{
    class CustomerConcBuilder : CustomerBuilder
    {
        public override void LogcustomerEvent()
        {
            Console.WriteLine("Log the customer event");
        }

        public override void Mobilenumberlog()
        {
            Console.WriteLine("Log the customer mobile");
        }

        public override void notificationtoCustomer()
        {
            Console.WriteLine("Send notification to customer");
        }

        public override void UserCreation()
        {
            Console.WriteLine("Create the user");
        }
    }
}
