using Builder.Builder;
using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
   public class CustomerDirector
    {
        public Person MakeUserObject(CustomerBuilder builder)
        {
            builder.Startperson();
            builder.Mobilenumberlog();
            builder.notificationtoCustomer();
            builder.LogcustomerEvent();
           return builder.Getperson();
        }
    }
}
