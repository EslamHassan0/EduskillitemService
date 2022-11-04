using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class Semester
    {
        public Semester()
        {
            DistribTeacherStudentClasses = new HashSet<DistribTeacherStudentClass>();
            EduPlanLongTargets = new HashSet<EduPlanLongTarget>();
            EduPlanStudies = new HashSet<EduPlanStudy>();
            EndTimePlans = new HashSet<EndTimePlan>();
            SportShortTargetPlans = new HashSet<SportShortTargetPlan>();
            TableClasses = new HashSet<TableClass>();
        }

        public int SemesterId { get; set; }
        public string Semester1 { get; set; }
        public int Year { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool? IsClosed { get; set; }

        public virtual YearStudy YearNavigation { get; set; }
        public virtual ICollection<DistribTeacherStudentClass> DistribTeacherStudentClasses { get; set; }
        public virtual ICollection<EduPlanLongTarget> EduPlanLongTargets { get; set; }
        public virtual ICollection<EduPlanStudy> EduPlanStudies { get; set; }
        public virtual ICollection<EndTimePlan> EndTimePlans { get; set; }
        public virtual ICollection<SportShortTargetPlan> SportShortTargetPlans { get; set; }
        public virtual ICollection<TableClass> TableClasses { get; set; }
    }
}
