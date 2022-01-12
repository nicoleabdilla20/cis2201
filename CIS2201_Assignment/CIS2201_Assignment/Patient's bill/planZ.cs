using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    // Derived Classes
    public class planZ : planBase
    {
        //Insurance covers the patient's full expenses
        int insurance;
        int toPay;
        public override int calculate(int expense)
        {
            insurance = expense;
            toPay = 0;
            return toPay;
        }
    }
}
