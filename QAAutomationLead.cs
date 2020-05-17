using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class QAAutomationLead : Employee, ITester, IDeveloper, ITaskAssigner
    {
        public string Team { get; set; }
        public QAAutomationLead(string firstNameValue, string lastNameValue, int passportValue, string team) : base(firstNameValue, lastNameValue, passportValue)

        {
            Team = team;

        }

        
        public override string GetFullInfo()

        {

            return FirstName + " " + LastName + ", " + "Passport Number: " + Passport.ToString() + " " + "Team: " + Team + '\n';

        }

        public void TestTask(string task)
        {
            throw new NotImplementedException();
        }

        public void CodeCreate(string code)
        {
            throw new NotImplementedException();
        }

        public void AssignTask(string task)
        {
            throw new NotImplementedException();
        }
    }
}