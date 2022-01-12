using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    public class planX : planBase
    {
        //Patient pays the full expenses
        int insurance;
        int toPay;
        public override int calculate(int expense)
        {
            insurance = 0;
            toPay = expense;
            return toPay;
        }
    }
}
