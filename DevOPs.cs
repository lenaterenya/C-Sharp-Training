using System;


namespace HW7
{
    class DevOPs: Employee
    {
        public string OS { get; set; }
        public DevOPs(string firstNameValue, string lastNameValue, int passportValue, string os) : base(firstNameValue, lastNameValue, passportValue)

        {
            OS = os;

        }
        public override string GetFullInfo()

        {

            return FirstName + " " + LastName + ", " + "Passport Number: " + Passport.ToString() + " " + "OS: " + OS + '\n';

        }
      /* public override void Work()
        {
        }  */
    }
}
