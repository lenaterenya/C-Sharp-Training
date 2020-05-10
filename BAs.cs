using System;


namespace HW7
{
    class BAs: Employee
    {
        public string Project { get; set; }
        public BAs(string firstNameValue, string lastNameValue, int passportValue, string project) : base(firstNameValue, lastNameValue, passportValue)

        {
            Project = project;

        }

        public override string GetFullInfo()

        {

            return FirstName + " " + LastName + ", " + "Passport Number: " + Passport.ToString() + " " + "Project: " + Project + '\n';

        }

       public override void Work()
        {
        } 
    }
}
