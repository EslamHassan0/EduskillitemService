using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidReportRecomSuper
    {
        public int ReportRecomSuperId { get; set; }
        public int RecomendSuperId { get; set; }
        public int ReportId { get; set; }

        public virtual ResidRepRecomendSuper RecomendSuper { get; set; }
        public virtual ResidFinalReport Report { get; set; }
    }
}
