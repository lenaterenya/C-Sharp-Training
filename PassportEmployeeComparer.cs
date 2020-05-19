using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class PassportEmployeeComparer : IComparer <Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Passport.CompareTo(y.Passport);
        }
    }
}