using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Model
{
  public  class Person
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get => this.Age; set => this.Age = DOB.Year - DateTime.Now.Year; }

        public void ShowPerson()
        {
            Console.WriteLine($"Name id {Name} & Mobile is {Mobile}");
        }
    }
}
