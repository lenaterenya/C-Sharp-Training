using System;


namespace HW7
{
    class QAs : Employee, ITester
    {

        public string Area { get; set; }
        public QAs(string firstNameValue, string lastNameValue, int passportValue, string area) : base(firstNameValue, lastNameValue, passportValue)

        {
            Area = area;

        }
        public override string GetFullInfo()

        {

            return FirstName + " " + LastName + ", " + "Passport Number: " + Passport.ToString() + " " + "Area: " + Area + '\n';

        }

        public void TestTask(string task)
        {
            Console.WriteLine(FirstName + " " + LastName + " can test task \"" + task + "\"");

        }
        /*   public override void Work()
   { 
   } */
    }
}
