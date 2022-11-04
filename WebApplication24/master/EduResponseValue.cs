using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduResponseValue
    {
        public EduResponseValue()
        {
            EduShortTargetAnalysisResponses = new HashSet<EduShortTargetAnalysisResponse>();
        }

        public byte ResponseValueId { get; set; }
        public string ResponseName { get; set; }
        public byte Value { get; set; }

        public virtual ICollection<EduShortTargetAnalysisResponse> EduShortTargetAnalysisResponses { get; set; }
    }
}
