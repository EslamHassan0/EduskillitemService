using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduPlanStudy
    {
        public EduPlanStudy()
        {
            EduPlanLongTargets = new HashSet<EduPlanLongTarget>();
            EduPlanStudyReports = new HashSet<EduPlanStudyReport>();
        }

        public int PlanStudyId { get; set; }
        public int StudentId { get; set; }
        public int SemesterId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool IsApproveSuperVisor { get; set; }
        public byte Action { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Semester Semester { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<EduPlanLongTarget> EduPlanLongTargets { get; set; }
        public virtual ICollection<EduPlanStudyReport> EduPlanStudyReports { get; set; }
    }
}
