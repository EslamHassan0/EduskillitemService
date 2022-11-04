using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuTool
    {
        public OccuTool()
        {
            OccuPlanLongTargets = new HashSet<OccuPlanLongTarget>();
        }

        public int ToolsId { get; set; }
        public string ToolName { get; set; }

        public virtual ICollection<OccuPlanLongTarget> OccuPlanLongTargets { get; set; }
    }
}
