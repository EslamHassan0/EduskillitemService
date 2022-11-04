using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class Semester
    {
        public Semester()
        {
            EduPlanStudies = new HashSet<EduPlanStudy>();
            EndTimePlans = new HashSet<EndTimePlan>();
        }

        public int SemesterId { get; set; }
        public string Semester1 { get; set; }
        public int Year { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool? IsClosed { get; set; }

        public virtual YearStudy YearNavigation { get; set; }
        public virtual ICollection<EduPlanStudy> EduPlanStudies { get; set; }
        public virtual ICollection<EndTimePlan> EndTimePlans { get; set; }
    }
}
