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


    }
}
