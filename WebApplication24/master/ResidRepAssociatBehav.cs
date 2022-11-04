using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidRepAssociatBehav
    {
        public ResidRepAssociatBehav()
        {
            ResidReportAssociBehavs = new HashSet<ResidReportAssociBehav>();
        }

        public int AssociatedBehavId { get; set; }
        public string AssociatedBehav { get; set; }

        public virtual ICollection<ResidReportAssociBehav> ResidReportAssociBehavs { get; set; }
    }
}
