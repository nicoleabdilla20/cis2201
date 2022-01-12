using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    //doctor pay rate calculation 
    public class payDoctor : payroll
    {
        public override void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
        {
            int rate = 30;
            pay = (rate * hours) + bonus;
            tax = 0.25 * pay;
            payfinal = 0.75 * pay;
        }
    }
}
