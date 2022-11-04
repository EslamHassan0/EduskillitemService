using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwRptPsyBehaviorForm
    {
        public int BehaviorMonitorId { get; set; }
        public int? SessionId { get; set; }
        public DateTime DateMonitor { get; set; }
        public string Location { get; set; }
        public string PeriodNotes { get; set; }
        public byte RepeatNo { get; set; }
        public int BehaviorFormId { get; set; }
        public int StudentId { get; set; }
        public string SourceInfo { get; set; }
        public DateTime DateSuggesFrom { get; set; }
        public DateTime DateSuggesTo { get; set; }
        public string BehaviorNedModify { get; set; }
        public string DescBehavior { get; set; }
        public int PlanBehaviorId { get; set; }
    }
}
