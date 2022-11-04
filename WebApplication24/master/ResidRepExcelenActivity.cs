using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidRepExcelenActivity
    {
        public ResidRepExcelenActivity()
        {
            ResidReportExcelenActivs = new HashSet<ResidReportExcelenActiv>();
        }

        public int ExcelenActivityId { get; set; }
        public string ExcelenActivity { get; set; }

        public virtual ICollection<ResidReportExcelenActiv> ResidReportExcelenActivs { get; set; }
    }
}
