using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    //PATIENT BILL CALCULATION
    public class planBase
    {
        public virtual int calculate(int expense)
        {
            return expense;
        }
    }
}
