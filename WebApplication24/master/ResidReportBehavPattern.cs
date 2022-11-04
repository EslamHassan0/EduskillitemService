using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidReportBehavPattern
    {
        public int ReportBehavPatternId { get; set; }
        public int BehavPatternId { get; set; }
        public int ReportId { get; set; }

        public virtual ResidRepBehavPattern BehavPattern { get; set; }
        public virtual ResidFinalReport Report { get; set; }
    }
}
