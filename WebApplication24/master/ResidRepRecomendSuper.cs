using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidRepRecomendSuper
    {
        public ResidRepRecomendSuper()
        {
            ResidReportRecomSupers = new HashSet<ResidReportRecomSuper>();
        }

        public int RecomendSuperId { get; set; }
        public string Recomendation { get; set; }

        public virtual ICollection<ResidReportRecomSuper> ResidReportRecomSupers { get; set; }
    }
}
