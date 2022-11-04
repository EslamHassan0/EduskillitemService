using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduAnalysisItem
    {
        public EduAnalysisItem()
        {
            EduShortTargetAnalyses = new HashSet<EduShortTargetAnalysis>();
        }

        public int AnalysisItemId { get; set; }
        public string AnalysisName { get; set; }

        public virtual ICollection<EduShortTargetAnalysis> EduShortTargetAnalyses { get; set; }
    }
}
