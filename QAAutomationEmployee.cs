﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class QAAutomationEmployee : Employee, ITester, IDeveloper
    {  
        public string Rate { get; set; }
        public QAAutomationEmployee(string firstNameValue, string lastNameValue, int passportValue, string rate) : base(firstNameValue, lastNameValue, passportValue)

    {
        Rate = rate;

    }
    public override string GetFullInfo()

    {

        return FirstName + " " + LastName + ", " + "Passport Number: " + Passport.ToString() + " " + "Rate: " + Rate + '\n';

    }

        public void TestTask(string task)
        {
            throw new NotImplementedException();
        }

        public void CodeCreate(string code)
        {
            throw new NotImplementedException();
        }
    }




}
