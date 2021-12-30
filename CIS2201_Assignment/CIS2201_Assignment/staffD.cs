using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    //Child class/derived class, inheriting from staff.cs
    public class staffD : staffs
    {
        public string StartOfContract { get; set; }
        public string EndOfContract { get; set; }
        public string TypeOfContract { get; set; }
        public string NumberOfHours { get; set; }
        public string Bonus { get; set; }
        public staffD(string id,  string startofcontract, string endofcontract, string typeofcontract, string numberofhours, string bonus) : base(id)
        {
            StartOfContract = startofcontract;
            EndOfContract = endofcontract;
            TypeOfContract = typeofcontract;
            NumberOfHours = numberofhours;
            Bonus = bonus;
        }
    }
}
