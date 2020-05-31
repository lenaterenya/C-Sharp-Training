using HW7;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static HW7.Employee;

namespace HW7
{
    class Company
    {
        public string CompanyName { get; private set; }
        public List<Employee> CompanyEmployees { get; private set; }
        public List<Office> Offices { get; set; }

        public delegate void Statistics(Employee employee);

        public Company(string companyNameValue, List<Employee> employeeValues, List<Office> offices)
        {
            CompanyName = companyNameValue;
            CompanyEmployees = new List<Employee>(employeeValues);
            Offices = new List<Office>(offices);
        }

        public string GetCompanyFullInfo()
        {
            string companyFullInfo = CompanyName + '\n';
            int officeSpare = 0;
            int roomSpare = 0;

            foreach (Employee employee in CompanyEmployees)
            {

                companyFullInfo = companyFullInfo + employee.GetFullInfo();

            }

            foreach (Office office in Offices)
            {
                roomSpare = office.Length * office.Width;
                officeSpare = officeSpare + roomSpare;
                companyFullInfo = companyFullInfo + office.GetFullOfficeInfo();

            }

            return companyFullInfo + officeSpare;

        }

        public void AssignFullTask(string task)
        {
            foreach (var employee in CompanyEmployees)
            {
                if (employee is IManager)
                {
                    (employee as IManager).AssignTask(task);

                }
            }

        }

        public void TestFullTask(string task)
        {
            foreach (var employee in CompanyEmployees)
            {
                if (employee is ITester)
                {
                    (employee as ITester).TestTask(task);

                }
            }

        }

        public void FullCodeCreate(string code)
        {
            foreach (var employee in CompanyEmployees)
            {
                if (employee is IDeveloper)
                {
                    (employee as IDeveloper).CodeCreate(code);

                }
            }

        }
        public static void CheckFirstNumber(Employee employee)
        {
            if (employee.Passport.ToString().Substring(0, 1) == "4")
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + "This is a man");
        }

        public static void Number(Employee employee)
        {
            if (employee.Passport.ToString().Substring(0, 1) == "3")
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + "This is a woman");
        }
        public void PassportCheck(Statistics activity, Employee employee)
        {
            activity(employee);
        }

        public void GetEmployeePassportStatistics()
        {
            Statistics method = CheckFirstNumber;
            Statistics method2 = Number;
            
            foreach (var employee in CompanyEmployees)
            {
                PassportCheck(method,employee);
                PassportCheck (method2, employee);
            }
        }

        public void AssignTheTask(string task)
        {
            foreach (var employee in CompanyEmployees)
            {
                if (employee is ITaskAssigner)
                {
                    (employee as ITaskAssigner).AssignTask(task);

                }
            }

        }

       


    }
}
