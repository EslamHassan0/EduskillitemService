using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronPlanTarget
    {
        public PronPlanTarget()
        {
            PronTargetGoals = new HashSet<PronTargetGoal>();
        }

        public int PlanTargetId { get; set; }
        public int PlanId { get; set; }
        public int LongTargetId { get; set; }
        public string Description { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual PronLongTarget LongTarget { get; set; }
        public virtual PronPlan Plan { get; set; }
        public virtual ICollection<PronTargetGoal> PronTargetGoals { get; set; }
    }
}
