using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    //therapist pay rate calculation 
    public class payTherapist : payroll
    {
        public override void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
        {
            int rate = 25;
            pay = (rate * hours) + bonus;
            tax = 0.25 * pay;
            payfinal = 0.75 * pay;
        }
    }
}
