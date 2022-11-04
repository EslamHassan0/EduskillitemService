using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduShortTargetAnalysis
    {
        public EduShortTargetAnalysis()
        {
            EduShortTargetAnalysisResponses = new HashSet<EduShortTargetAnalysisResponse>();
        }

        public int ShortTargetAnalysisId { get; set; }
        public int ShortTargetId { get; set; }
        public int AnalysisItemId { get; set; }
        public float? TotalResponseDegree { get; set; }
        public byte? Action { get; set; }

        public virtual EduAnalysisItem AnalysisItem { get; set; }
        public virtual EduShortTarget ShortTarget { get; set; }
        public virtual ICollection<EduShortTargetAnalysisResponse> EduShortTargetAnalysisResponses { get; set; }
    }
}
