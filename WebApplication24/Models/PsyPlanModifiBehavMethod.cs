using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class PsyPlanModifiBehavMethod
    {
        public int PlanMethodId { get; set; }
        public int PlanBehaviorId { get; set; }
        public int BehavAnalysisItemId { get; set; }
        public string MethodName { get; set; }

        public virtual PsyBehavAnalysisItem BehavAnalysisItem { get; set; }
        public virtual PsyPlanModifiBehavior PlanBehavior { get; set; }
    }
}
