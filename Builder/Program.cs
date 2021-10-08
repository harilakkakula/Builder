using Builder.ConcreteBuilder;
using Builder.Directors;
using Builder.Model;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            CustomerDirector persondirector = new CustomerDirector();
            CustomerConcBuilder builder = new CustomerConcBuilder();
            person = persondirector.MakeUserObject(builder);
            person.ShowPerson();
            Console.ReadLine();
        }
    }
}
