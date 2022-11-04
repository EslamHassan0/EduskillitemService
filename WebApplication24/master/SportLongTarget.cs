using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class SportLongTarget
    {
        public SportLongTarget()
        {
            SportShortTargets = new HashSet<SportShortTarget>();
        }

        public int LongTargetId { get; set; }
        public int FieldId { get; set; }
        public string LongTargetName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual SportField Field { get; set; }
        public virtual ICollection<SportShortTarget> SportShortTargets { get; set; }
    }
}
