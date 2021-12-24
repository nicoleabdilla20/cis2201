using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    //Child class/derived class, inheriting from patient.cs
    class patientAppointmet : patient
    {
        public string AppID { get; set; }
        public string Doctor { get; set; }
        public string CreationDate { get; set; }
        public string ScheduledDate { get; set; }

        public patientAppointmet(string appid, string id, string name, string surname, string doctor, string creationdate, string scheduleddate) : base(id, name, surname)
        {

            AppID = appid;
            Doctor = doctor;
            CreationDate = creationdate;
            ScheduledDate = scheduleddate;
        }
    }
}
