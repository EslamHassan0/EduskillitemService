using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PsyBehavAnalysisItem
    {
        public PsyBehavAnalysisItem()
        {
            InverseParentNavigation = new HashSet<PsyBehavAnalysisItem>();
            PsyPlanModifiBehavMethEncrages = new HashSet<PsyPlanModifiBehavMethEncrage>();
            PsyPlanModifiBehavMethods = new HashSet<PsyPlanModifiBehavMethod>();
        }

        public int BehavAnalysisItemId { get; set; }
        public int? Parent { get; set; }
        public string ItemName { get; set; }

        public virtual PsyBehavAnalysisItem ParentNavigation { get; set; }
        public virtual ICollection<PsyBehavAnalysisItem> InverseParentNavigation { get; set; }
        public virtual ICollection<PsyPlanModifiBehavMethEncrage> PsyPlanModifiBehavMethEncrages { get; set; }
        public virtual ICollection<PsyPlanModifiBehavMethod> PsyPlanModifiBehavMethods { get; set; }
    }
}
