using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidReportExcelenActiv
    {
        public int ReportExcelenActId { get; set; }
        public int ReportId { get; set; }
        public int ExcelenActivityId { get; set; }

        public virtual ResidRepExcelenActivity ExcelenActivity { get; set; }
        public virtual ResidFinalReport Report { get; set; }
    }
}
