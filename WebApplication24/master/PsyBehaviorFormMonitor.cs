using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PsyBehaviorFormMonitor
    {
        public int BehaviorMonitorId { get; set; }
        public int? SessionId { get; set; }
        public int BehaviorFormId { get; set; }
        public DateTime DateMonitor { get; set; }
        public string Location { get; set; }
        public string PeriodNotes { get; set; }
        public byte RepeatNo { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual PsyBehaviorForm BehaviorForm { get; set; }
    }
}
