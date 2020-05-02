using System;
namespace HW7
{
    class Company
    {
        public string CompanyName { get; private set; }
        public Employee[] CompanyEmployees { get; private set; }
        public Office[] Offices { get; set; }
        


        public Company(string companyNameValue, Employee[] employeeValues, Office[] offices)
        {
            CompanyName = companyNameValue;
            CompanyEmployees = employeeValues;
            Offices = offices;
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
