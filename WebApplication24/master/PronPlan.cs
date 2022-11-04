using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronPlan
    {
        public PronPlan()
        {
            PronPlanTargets = new HashSet<PronPlanTarget>();
        }

        public int PlanId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public string Recomendation { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<PronPlanTarget> PronPlanTargets { get; set; }
    }
}
