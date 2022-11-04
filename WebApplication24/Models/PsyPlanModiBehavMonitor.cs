using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class PsyPlanModiBehavMonitor
    {
        public int PmbehaviorMonitorId { get; set; }
        public int? PlanBehaviorId { get; set; }
        public bool? TypeMonitor { get; set; }
        public DateTime DateMonitor { get; set; }
        public string Location { get; set; }
        public string PeriodNotes { get; set; }
        public byte RepeatNo { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual PsyPlanModifiBehavior PlanBehavior { get; set; }
    }
}
