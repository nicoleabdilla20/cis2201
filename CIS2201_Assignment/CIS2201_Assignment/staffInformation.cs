using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    class staffInformation : staffs
    {
        //Child class/derived class, inheriting from staff.cs
        public string Gender { get; set; }
        public string DateofBirth { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string BloodType { get; set; }
        public string Insurance { get; set; }
        public string Role { get; set; }

        public staffInformation(string id, string name, string surname, string gender, string dateofbirth, string age, string address, string phonenumber, string bloodtype,  string insurance, string role) : base(id, name, surname)
        {
            Gender = gender;
            DateofBirth = dateofbirth;
            Age = age;
            Address = address;
            Telephone = phonenumber;
            BloodType = bloodtype;
            Insurance = insurance;
            Role = role;
        }
    }
}
