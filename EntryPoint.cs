using System;

namespace HW7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Employee[] employeeValues = new Employee[26];
            employeeValues[0] = new Employee("Ben", "Gun", 216578);
            employeeValues[1] = new Employee("John", "Connor", 225662);
            employeeValues[2] = new Employee("Sarah", "Connor", 289783);
            employeeValues[3] = new Employee("Jon", "Snow", 437724);
            employeeValues[4] = new Employee("Luke", "Skywalker", 976825);
            employeeValues[5] = new Employee("Forrest", "Gump", 342426);
            employeeValues[6] = new Employee("Darth", "Vader", 265347);
            employeeValues[7] = new Employee("Richard", "Doe", 225468);
            employeeValues[8] = new Employee("John", "Doe", 768429);
            employeeValues[9] = new Employee("Jane", "Doe", 346360);

            employeeValues[10] = new QAs("Tim", "Rot", 456345, "Automation");
            employeeValues[11] = new QAs("Tanya", "Shines", 876976, "WEB");
            employeeValues[12] = new QAs("Sam", "Johnes", 967565, "Mobile");
            employeeValues[13] = new QAs("Jane", "Houston", 547342, "Desktop");
            
            employeeValues[14] = new Devs("Mike", "Simpson", 456345, "C##");
            employeeValues[15] = new Devs("Kate", "Norson", 786976, "C++");
            employeeValues[16] = new Devs("Andrew", "Kidneys", 548565, "Java");
            employeeValues[17] = new Devs("Sam", "Krew", 567442, "JS");
            
            employeeValues[18] = new BAs("Anthony", "White", 657455, "STAR");
            employeeValues[19] = new BAs("Mike", "Nolton", 789786, "WiseMan");
            employeeValues[20] = new BAs("Chris", "Suners", 987867, "Greys");
            employeeValues[21] = new BAs("Kate", "Snows", 598742, "Johnsons");
            
            employeeValues[22] = new DevOPs("Andy", "Dick", 659955, "Linux Ubuntu");
            employeeValues[23] = new DevOPs("Norah", "Drake", 778686, "Linux Debian");
            employeeValues[24] = new DevOPs("Summer", "Brights", 876867, "Windows 10");
            employeeValues[25] = new DevOPs("Tim", "Dreyns", 587642, "Linux Fedora");



            Office[] offices = new Office[10];
            offices[0] = new Office("Chapaeva,5", 20, 34);
            offices[1] = new Office("Chapaeva,5", 17, 25);
            offices[2] = new Office("Gurskogo,44", 24, 25);
            offices[3] = new Office("Gurskogo,44", 28, 30);
            offices[4] = new Office("Gurskogo,44", 33, 35);
            offices[5] = new Office("Gurskogo,44", 30, 35);
            offices[6] = new Office("Gurskogo,44", 32, 38);
            offices[7] = new Office("Chapaeva,5", 20, 38);
            offices[8] = new Office("Gurskogo,44", 19, 28);
            offices[9] = new Office("Gurskogo,44", 35, 36);

            Company company = new Company("Microsoft", employeeValues, offices);

            Console.WriteLine(company.GetCompanyFullInfo());
            
          
        }
    
     }
}