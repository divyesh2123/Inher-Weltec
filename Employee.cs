using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Employee : BaseClass
    {
        internal Employee()
        {
           
        }
            internal Employee(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private string FirstName { get; set; }

        private string LastName { get; set; }

        public void Display()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }


      

    }
}
