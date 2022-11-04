using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuLongTargCurStatu
    {
        public OccuLongTargCurStatu()
        {
            OccuPlanLongTargets = new HashSet<OccuPlanLongTarget>();
        }

        public int CurrentStatusId { get; set; }
        public string CurrentStatus { get; set; }

        public virtual ICollection<OccuPlanLongTarget> OccuPlanLongTargets { get; set; }
    }
}
