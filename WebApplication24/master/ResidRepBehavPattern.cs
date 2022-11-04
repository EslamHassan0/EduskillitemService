using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidRepBehavPattern
    {
        public ResidRepBehavPattern()
        {
            ResidReportBehavPatterns = new HashSet<ResidReportBehavPattern>();
        }

        public int BehavPatternId { get; set; }
        public string BehavPattern { get; set; }

        public virtual ICollection<ResidReportBehavPattern> ResidReportBehavPatterns { get; set; }
    }
}
