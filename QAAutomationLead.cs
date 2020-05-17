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
            Console.WriteLine(FirstName + " " + LastName + " can test task \"" + task + "\"");
        }

        public void CodeCreate(string code)
        {
            Console.WriteLine(FirstName + " " + LastName + " can code create \"" + code + "\"");
        }

        public void AssignTask(string task)
        {
            Console.WriteLine(FirstName + " " + LastName + " can assign task \"" + task + "\"");
        }
    }
}