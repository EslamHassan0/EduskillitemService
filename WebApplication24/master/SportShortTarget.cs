using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class SportShortTarget
    {
        public SportShortTarget()
        {
            SportShortTargetPlans = new HashSet<SportShortTargetPlan>();
        }

        public int ShortTargetId { get; set; }
        public int LongTargetId { get; set; }
        public string ShortTargetName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual SportLongTarget LongTarget { get; set; }
        public virtual ICollection<SportShortTargetPlan> SportShortTargetPlans { get; set; }
    }
}
