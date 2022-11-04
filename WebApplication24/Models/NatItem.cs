using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class NatItem
    {
        public NatItem()
        {
            NatAssesmentItems = new HashSet<NatAssesmentItem>();
        }

        public int ItemId { get; set; }
        public int ItemGrpId { get; set; }
        public string ItemName { get; set; }

        public virtual NatItemGroup ItemGrp { get; set; }
        public virtual ICollection<NatAssesmentItem> NatAssesmentItems { get; set; }
    }
}
