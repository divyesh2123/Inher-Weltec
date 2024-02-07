using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class EmployeeD : Person
    {
        private double salary;
        public EmployeeD(double sal, string firstName, string lastName, string emailAddress, DateTime dateTime) : 
            base(firstName,lastName,emailAddress,dateTime)
        {
            salary= sal;
        }

        public void Display()
        {
            Console.WriteLine(IsBirthDay);
            Console.WriteLine(IsAdult);
            Console.WriteLine(salary);
            Console.WriteLine(ScreenName);
        }
    }
}
