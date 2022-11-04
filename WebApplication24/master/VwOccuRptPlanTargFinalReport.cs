using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwOccuRptPlanTargFinalReport
    {
        public string CreateByUser { get; set; }
        public string LongTargetName { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public int Serial { get; set; }
        public DateTime Birthday { get; set; }
        public int? CurrentStatusId { get; set; }
        public string CurrentStatus { get; set; }
        public int LongTargetId { get; set; }
        public int? PlanTermId { get; set; }
        public DateTime Date { get; set; }
        public byte Action { get; set; }
        public string Recomendation { get; set; }
        public string ToolName { get; set; }
        public string MethodName { get; set; }
        public string ShortTargetName { get; set; }
    }
}
