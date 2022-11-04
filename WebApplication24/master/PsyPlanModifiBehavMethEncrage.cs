using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PsyPlanModifiBehavMethEncrage
    {
        public int MethodEncourageId { get; set; }
        public int PlanBehaviorId { get; set; }
        public int BehavAnalysisItemId { get; set; }
        public int EncourageTypeId { get; set; }
        public string EncourageMethod { get; set; }

        public virtual PsyBehavAnalysisItem BehavAnalysisItem { get; set; }
        public virtual PsyEncourageType EncourageType { get; set; }
        public virtual PsyPlanModifiBehavior PlanBehavior { get; set; }
    }
}
