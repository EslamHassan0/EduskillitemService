using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatItemValue
    {
        public NatItemValue()
        {
            NatAssesmentItems = new HashSet<NatAssesmentItem>();
        }

        public int ItemValueId { get; set; }
        public int? ItemGrpId { get; set; }
        public string ItemValue { get; set; }

        public virtual NatItemGroup ItemGrp { get; set; }
        public virtual ICollection<NatAssesmentItem> NatAssesmentItems { get; set; }
    }
}
