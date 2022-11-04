using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatItemGroup
    {
        public NatItemGroup()
        {
            NatItemValues = new HashSet<NatItemValue>();
            NatItems = new HashSet<NatItem>();
        }

        public int ItemGrpId { get; set; }
        public string GroupName { get; set; }
        public byte? DataType { get; set; }

        public virtual ICollection<NatItemValue> NatItemValues { get; set; }
        public virtual ICollection<NatItem> NatItems { get; set; }
    }
}
