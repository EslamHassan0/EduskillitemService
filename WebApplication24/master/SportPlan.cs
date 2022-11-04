using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class SportPlan
    {
        public SportPlan()
        {
            SportReportStudents = new HashSet<SportReportStudent>();
            SportShortTargetPlans = new HashSet<SportShortTargetPlan>();
        }

        public int PlanId { get; set; }
        public int StudentId { get; set; }
        public int? Department { get; set; }
        public DateTime Date { get; set; }
        public string PlanType { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual User CreateByNavigation { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<SportReportStudent> SportReportStudents { get; set; }
        public virtual ICollection<SportShortTargetPlan> SportShortTargetPlans { get; set; }
    }
}
