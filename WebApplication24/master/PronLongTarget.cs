using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronLongTarget
    {
        public PronLongTarget()
        {
            PronPlanTargets = new HashSet<PronPlanTarget>();
        }

        public int LongTargetId { get; set; }
        public string LongTargetName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<PronPlanTarget> PronPlanTargets { get; set; }
    }
}
