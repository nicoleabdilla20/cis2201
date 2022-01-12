using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    class medications
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string BloodType { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public string Maintenance { get; set; }

        public medications(string type, string name, string bloodtype, string stock, string price, string maintenance)
        {
            Type = type;
            Name = name;
            BloodType = bloodtype;
            Stock = stock;
            Price = price;
            Maintenance = maintenance;
        }
    }
}
