using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduPlanStudyReport
    {
        public int PlanReportId { get; set; }
        public int PlanStudyId { get; set; }
        public string Report { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual EduPlanStudy PlanStudy { get; set; }
    }
}
