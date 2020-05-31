using HW7;
using System;
using System.Collections.Generic;

namespace HW7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Employee> employeeValues = new List<Employee>();

            /*employeeValues.Add(new Employee("Ben", "Gun", 216578));
            employeeValues.Add(new Employee("John", "Connor", 225662));
            employeeValues.Add(new Employee("Sarah", "Connor", 289783));
            employeeValues.Add(new Employee("Jon", "Snow", 437724));
            employeeValues.Add(new Employee("Luke", "Skywalker", 976825));
            employeeValues.Add(new Employee("Forrest", "Gump", 342426));
            employeeValues.Add(new Employee("Darth", "Vader", 265347));
            employeeValues.Add(new Employee("Richard", "Doe", 225468));
            employeeValues.Add(new Employee("John", "Doe", 768429));
            employeeValues.Add(new Employee("Jane", "Doe", 346360)); */

            employeeValues.Add(new QAs("Tim", "Rot", 456345, "Automation"));
            employeeValues.Add(new QAs("Tanya", "Shines", 876976, "WEB"));
            employeeValues.Add(new QAs("Sam", "Johnes", 967565, "Mobile"));
            employeeValues.Add(new QAs("Jane", "Houston", 547342, "Desktop"));

            employeeValues.Add(new QAAutomationLead("Sam", "Ows", 598742, "Tulips"));
            employeeValues.Add(new QAAutomationLead("Andy", "Sworles", 765342, "Monkeys"));
            employeeValues.Add(new QAAutomationLead("Jessica", "Moony", 547844, "Autos"));

            employeeValues.Add(new QAAutomationEmployee("Nick", "Lack", 675657, "full"));
            employeeValues.Add(new QAAutomationEmployee("Karry", "Stevens", 549787, "full"));
            employeeValues.Add(new QAAutomationEmployee("Steven", "Krins", 778844, "half"));

            employeeValues.Add(new Devs("Mike", "Simpson", 456345, "C##"));
            employeeValues.Add(new Devs("Kate", "Norson", 386976, "C++"));
            employeeValues.Add(new Devs("Andrew", "Kidneys", 548565, "Java"));
            employeeValues.Add(new Devs("Sam", "Krew", 567442, "JS"));

            employeeValues.Add(new BAs("Anthony", "White", 657455, "STAR"));
            employeeValues.Add(new BAs("Mike", "Nolton", 789786, "WiseMan"));
            employeeValues.Add(new BAs("Chris", "Suners", 987867, "Greys"));
            employeeValues.Add(new BAs("Kate", "Snows", 398742, "Johnsons"));

            employeeValues.Add(new DevOPs("Andy", "Dick", 659955, "Linux Ubuntu"));
            employeeValues.Add(new DevOPs("Norah", "Drake", 378686, "Linux Debian"));
            employeeValues.Add(new DevOPs("Summer", "Brights", 376867, "Windows 10"));
            employeeValues.Add(new DevOPs("Tim", "Dreyns", 587642, "Linux Fedora"));


            List<Office> offices = new List<Office>();

            offices.Add(new Office("Chapaeva,5", 20, 34));
            offices.Add(new Office("Chapaeva,5", 17, 25));
            offices.Add(new Office("Gurskogo,44", 24, 25));
            offices.Add(new Office("Gurskogo,44", 28, 30));
            offices.Add(new Office("Gurskogo,44", 33, 35));
            offices.Add(new Office("Gurskogo,44", 30, 35));
            offices.Add(new Office("Gurskogo,44", 32, 38));
            offices.Add(new Office("Chapaeva,5", 20, 38));
            offices.Add(new Office("Gurskogo,44", 19, 28));
            offices.Add(new Office("Gurskogo,44", 35, 36));


            Company company = new Company("Microsoft", employeeValues, offices);

            company.TestFullTask("TestTask");
            company.AssignTheTask("Test Execution");
            company.FullCodeCreate("C#");

            company.CompanyEmployees.Sort(new FirstNameEmployeeComparer());
            company.CompanyEmployees.Sort(new LastNameEmployeeComparer());
            company.CompanyEmployees.Sort(new PassportEmployeeComparer());
            company.Offices.Sort(new RoomSpareOfficeComparer()); 

            Console.WriteLine(company.GetCompanyFullInfo());

            company.GetEmployeePassportStatistics();
        }
    
     }
}