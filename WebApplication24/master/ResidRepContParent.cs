using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidRepContParent
    {
        public ResidRepContParent()
        {
            ResidReportContParents = new HashSet<ResidReportContParent>();
        }

        public int ContactParentId { get; set; }
        public string ContactParent { get; set; }

        public virtual ICollection<ResidReportContParent> ResidReportContParents { get; set; }
    }
}
