using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuPlan
    {
        public OccuPlan()
        {
            OccuPlanLongTargets = new HashSet<OccuPlanLongTarget>();
        }

        public int PlanTermId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public byte Action { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SessionId { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<OccuPlanLongTarget> OccuPlanLongTargets { get; set; }
    }
}
