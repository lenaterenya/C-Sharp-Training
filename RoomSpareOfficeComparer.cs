using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class RoomSpareOfficeComparer : IComparer<Office>
    {
        public int Compare(Office x, Office y)
        {
            return (x.Length * x.Width)-(y.Length * y.Width);
        }
    }
}