using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    //Parent class/Super Class.
    public class patient
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public patient(string id, string name, string surname)
        {
            ID = id;
            Name = name;
            Surname = surname;  
        }
    }
}
