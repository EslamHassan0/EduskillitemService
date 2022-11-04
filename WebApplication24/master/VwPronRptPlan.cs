using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwPronRptPlan
    {
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public DateTime? DatePlan { get; set; }
        public string Goals { get; set; }
        public string CreateBy { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public string Achievement { get; set; }
        public int PlanId { get; set; }
        public int? AchievementId { get; set; }
        public DateTime Birthday { get; set; }
        public bool SexType { get; set; }
        public int? FileNo { get; set; }
        public int? ReportId { get; set; }
        public string Description { get; set; }
        public string LongTargetName { get; set; }
        public int PlanTargetId { get; set; }
    }
}
