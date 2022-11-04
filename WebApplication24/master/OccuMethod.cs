using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuMethod
    {
        public OccuMethod()
        {
            OccuPlanLongTargets = new HashSet<OccuPlanLongTarget>();
        }

        public int MethodId { get; set; }
        public string MethodName { get; set; }

        public virtual ICollection<OccuPlanLongTarget> OccuPlanLongTargets { get; set; }
    }
}
