using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class LastNameEmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
}