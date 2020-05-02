using System;


namespace HW7
{
    class Devs: Employee
    {
        public string Language { get; set; }
        public Devs (string firstNameValue, string lastNameValue, int passportValue, string language) : base(firstNameValue, lastNameValue, passportValue)

        {
            Language = language;

        }

        public override string GetFullInfo()

        {

            return FirstName + " " + LastName + ", " + "Passport Number: " + Passport.ToString() + " " + "Language: " + Language + '\n';

        }

    }
}
