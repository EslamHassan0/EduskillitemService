using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidReportAssociBehav
    {
        public int ReportAssociBehavId { get; set; }
        public int AssociatedBehavId { get; set; }
        public int ReportId { get; set; }

        public virtual ResidRepAssociatBehav AssociatedBehav { get; set; }
        public virtual ResidFinalReport Report { get; set; }
    }
}
