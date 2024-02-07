using MyCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeD employeeD = new EmployeeD(100000, "Dsd3223", "la234", "test@test.com", DateTime.Now.AddYears(-20));


            employeeD.Display();
            //Employee dd= new Employee();

            //Employee employee = new Employee("div", "patel");

            //dd.Display();
            Console.ReadKey();
        }
    }
}
