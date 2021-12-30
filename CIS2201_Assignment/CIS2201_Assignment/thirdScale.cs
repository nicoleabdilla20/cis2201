using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    class thirdScale : IStaffPayroll
    {
        public int Hours { get; set; }
        public string Role { get; set; }

        public thirdScale(int hours, string role)
        {
            Hours = hours;
            Role = role;
        }

        public int GetStaffPayroll()
        {
            return (int)(Hours * 20);
        }

        public override string ToString() => $"This {Role} has earned €{Hours}";

    }
}
