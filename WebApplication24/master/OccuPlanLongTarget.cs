using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuPlanLongTarget
    {
        public OccuPlanLongTarget()
        {
            OccuLongShortTargs = new HashSet<OccuLongShortTarg>();
        }

        public int LongTargetId { get; set; }
        public string LongTargetName { get; set; }
        public int? PlanTermId { get; set; }
        public int? ToolsId { get; set; }
        public int? MethodId { get; set; }
        public string Notes { get; set; }
        public int? RecomendationId { get; set; }
        public string Recomendation { get; set; }
        public int? CurrentStatusId { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int SessionId { get; set; }

        public virtual OccuLongTargCurStatu CurrentStatus { get; set; }
        public virtual OccuMethod Method { get; set; }
        public virtual OccuPlan PlanTerm { get; set; }
        public virtual OccuLongTargRecomend RecomendationNavigation { get; set; }
        public virtual OccuTool Tools { get; set; }
        public virtual ICollection<OccuLongShortTarg> OccuLongShortTargs { get; set; }
    }
}
