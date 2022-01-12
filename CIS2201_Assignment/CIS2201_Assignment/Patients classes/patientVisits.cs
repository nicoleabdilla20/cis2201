using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2201_Assignment
{
    //Child class/derived class, inheriting from patient.cs
    public class patientVisits : patient
    {
        public string RecentVisitDate { get; set; }
        public string RecentVisitDoctor { get; set; }
        public string RecentVisitSummary { get; set; }
        public string OtherVisitDate { get; set; }
        public string OtherVisitDoctor { get; set; }
        public string OtherVisitSummary { get; set; }
        public patientVisits(string id, string name, string surname, string recentvisitdate, string recentvisitdoctor, string recentvisitsummary, string othervisitdate, string othervisitdoctor, string othervisitsummary) : base(id, name, surname)
        {
            RecentVisitDate = recentvisitdate;
            RecentVisitDoctor = recentvisitdoctor;
            RecentVisitSummary = recentvisitsummary;
            OtherVisitDate = othervisitdate;
            OtherVisitDoctor = othervisitdoctor;
            OtherVisitSummary = othervisitsummary;
        }
    }
}
