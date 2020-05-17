using HW6;
using System;
using System.Collections.Generic;

namespace HW7
{
    class Company
    {
        public string CompanyName { get; private set; }
        public List<Employee> CompanyEmployees { get; private set; }
        public List<Office> Offices { get; set; }
        


        public Company(string companyNameValue, List<Employee> employeeValues, List<Office> offices)
        {
            CompanyName = companyNameValue;
            CompanyEmployees = new List<Employee>(employeeValues);
            Offices = new List <Office>(offices);
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
                roomSpare = office.Length*office.Width;
                officeSpare = officeSpare + roomSpare;
                companyFullInfo = companyFullInfo + office.GetFullOfficeInfo();

            } 

            return companyFullInfo + officeSpare;
            
        }
        
        public void AssignFullTask (string task)
        {
            foreach (var employee in CompanyEmployees)
            {
                if (employee is IManager)
                {
                    (employee as IManager).AssignTask(task);
                    return;

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
                    return;

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
                    return;

                }
            }

        }

        public void AssignTheTask(string task)
        {
            foreach (var employee in CompanyEmployees)
            {
                if (employee is ITaskAssigner)
                {
                    (employee as ITaskAssigner).AssignTask(task);
                    return;

                }
            }

        }
    }
}
