using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    class patientInformation : patient
    {
        //Child class/derived class, inheriting from patient.cs
        public string Gender { get; set; }
        public string DateofBirth { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public string Insurance { get; set; }

        public patientInformation(string id, string name, string surname, string gender, string dateofbirth, string age, string address, string telephone, string bloddtype, string allergies, string insurance) : base(id, name, surname)
        {
            Gender = gender;
            DateofBirth = dateofbirth;
            Age = age;
            Address = address;
            Telephone = telephone;
            BloodType = bloddtype;
            Allergies = allergies;
            Insurance = insurance;
        }
    }
}
