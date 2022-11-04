using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class PsyBehaviorForm
    {
        public PsyBehaviorForm()
        {
            PsyBehaviorFormMonitors = new HashSet<PsyBehaviorFormMonitor>();
            PsyPlanModifiBehaviors = new HashSet<PsyPlanModifiBehavior>();
        }

        public int BehaviorFormId { get; set; }
        public int? SessionId { get; set; }
        public int StudentId { get; set; }
        public string SourceInfo { get; set; }
        public DateTime DateSuggesFrom { get; set; }
        public DateTime DateSuggesTo { get; set; }
        public string BehaviorNedModify { get; set; }
        public string DescBehavior { get; set; }
        public string BehaviorOccur { get; set; }
        public string BeforeBehavior { get; set; }
        public string AfterBehavior { get; set; }
        public string ActionTake { get; set; }
        public string Teacher { get; set; }
        public string Supervisor { get; set; }
        public string Notes { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<PsyBehaviorFormMonitor> PsyBehaviorFormMonitors { get; set; }
        public virtual ICollection<PsyPlanModifiBehavior> PsyPlanModifiBehaviors { get; set; }
    }
}
