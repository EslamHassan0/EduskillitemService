using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidReportFavActivity
    {
        public int ReportFavActivityId { get; set; }
        public int FavActivityId { get; set; }
        public int ReportId { get; set; }

        public virtual ResidRepFavActivity FavActivity { get; set; }
        public virtual ResidFinalReport Report { get; set; }
    }
}
