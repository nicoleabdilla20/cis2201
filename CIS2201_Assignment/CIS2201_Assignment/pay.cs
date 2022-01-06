using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    internal class pay
    {
        //PAY STAFF CALCULATIONS
        public class payroll
        {
            public virtual void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
            {
            }
        }

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

        //nurse pay rate calculation 
        public class payNurse : payroll
        {

            public override void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
            {
                int rate = 15;
                pay = (rate * hours) + bonus;
                tax = 0.25 * pay;
                payfinal = 0.75 * pay;
            }
        }

        //physician pay rate calculation 
        public class payPhysicians : payroll
        {

            public override void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
            {
                int rate = 20;
                pay = (rate * hours) + bonus;
                tax = 0.25 * pay;
                payfinal = 0.75 * pay;
            }
        }


        //PATIENT BILL CALCULATION

        public class planBase
        {
            public virtual int calculate(int expense)
            {
                return expense;
            }
        }

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
}
