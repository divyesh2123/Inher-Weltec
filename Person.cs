using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Person
    {
        private string FirstName;
        private string LastName;
        private string EmailAddress;
        private DateTime DateOfBirth;

        public bool IsAdult
        {
            get
            {
               int year = DateTime.Now.Year - DateOfBirth.Year;
                
                return year >=  18? true : false;
            }
        }

        public bool IsBirthDay
        {
            get
            {

                return DateTime.Now.Month == DateOfBirth.Month &&
                    DateOfBirth.Day == DateTime.Now.Day ? true : false;
            }
        }

        public string ScreenName
        {
            get
            {
                return FirstName.Substring(0,2) + " " + LastName.Substring(0,2) + DateOfBirth.Year + DateOfBirth.Month;
            }
        }

        internal Person(string firstName,string lastName,string emailAddress,DateTime dateTime)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            DateOfBirth = dateTime;

        }

      
    }
}
