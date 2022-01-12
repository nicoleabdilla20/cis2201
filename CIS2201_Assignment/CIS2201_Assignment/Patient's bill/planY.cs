using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    public class planY : planBase
    {
        // insurance pays 50% of the expenses if expenses are larger than 700, if not the patient pays the full expense
        int insurance;
        int toPay;
        public override int calculate(int expense)
        {
            if (expense >= 700)
            {
                insurance = expense / 2;
                toPay = expense / 2;
                return toPay;
            }
            else
            {
                insurance = 0;
                toPay = expense;
                return toPay;
            }
        }
    }
}
