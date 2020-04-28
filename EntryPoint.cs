using System;

namespace HW7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Employee[] employeeValues = new Employee[10];
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