using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
   public abstract class CustomerBuilder
    {
        protected Person person;
        public abstract void Mobilenumberlog();
        public abstract void LogcustomerEvent();
        public abstract void UserCreation();
        public abstract void notificationtoCustomer();

        public void Startperson()
        {
            person = new Person();
        }
        public Person Getperson()
        {
            return person;
        }

    }
}
