using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuLongShortTarg
    {
        public int LongShortTargId { get; set; }
        public int ShortTargetId { get; set; }
        public int LongTargetId { get; set; }

        public virtual OccuPlanLongTarget LongTarget { get; set; }
        public virtual OccuShortTarget ShortTarget { get; set; }
    }
}
