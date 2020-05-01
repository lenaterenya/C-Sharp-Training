using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Passport { get; private set; }

        public Employee(string firstNameValue, string lastNameValue, int passportValue)
        {
            FirstName = firstNameValue;
            LastName = lastNameValue;
            Passport = passportValue;
        }

        public string GetFullInfo()
        {
            return FirstName + " " + LastName + ", " + "Passport Number: " + Passport.ToString() + '\n';        
        }

    }
}
