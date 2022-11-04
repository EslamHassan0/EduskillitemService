using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class PsyPlanModifiBehavior
    {
        public PsyPlanModifiBehavior()
        {
            PsyPlanModiBehavMonitors = new HashSet<PsyPlanModiBehavMonitor>();
            PsyPlanModifiBehavMethEncrages = new HashSet<PsyPlanModifiBehavMethEncrage>();
            PsyPlanModifiBehavMethods = new HashSet<PsyPlanModifiBehavMethod>();
        }

        public int PlanBehaviorId { get; set; }
        public string TargetPlane { get; set; }
        public int BehaviorFormId { get; set; }
        public DateTime PostDate { get; set; }
        public string Examineby { get; set; }

        public virtual PsyBehaviorForm BehaviorForm { get; set; }
        public virtual ICollection<PsyPlanModiBehavMonitor> PsyPlanModiBehavMonitors { get; set; }
        public virtual ICollection<PsyPlanModifiBehavMethEncrage> PsyPlanModifiBehavMethEncrages { get; set; }
        public virtual ICollection<PsyPlanModifiBehavMethod> PsyPlanModifiBehavMethods { get; set; }
    }
}
