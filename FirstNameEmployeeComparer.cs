using HW7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class FirstNameEmployeeComparer : IComparer <Employee>
    {
        public int Compare (Employee x,Employee y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }
}
