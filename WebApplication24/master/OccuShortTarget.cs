using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuShortTarget
    {
        public OccuShortTarget()
        {
            OccuLongShortTargs = new HashSet<OccuLongShortTarg>();
        }

        public int ShortTargetId { get; set; }
        public string ShortTargetName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int SessionId { get; set; }

        public virtual ICollection<OccuLongShortTarg> OccuLongShortTargs { get; set; }
    }
}
