using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidReportContParent
    {
        public int ReportContParentId { get; set; }
        public int ContactParentId { get; set; }
        public int ReportId { get; set; }

        public virtual ResidRepContParent ContactParent { get; set; }
        public virtual ResidFinalReport Report { get; set; }
    }
}
