using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatAssesmentItem
    {
        public int AssesmentItemId { get; set; }
        public int AssesmentId { get; set; }
        public string GroupName { get; set; }
        public int ItemId { get; set; }
        public int? ItemValueId { get; set; }

        public virtual NatAssesment Assesment { get; set; }
        public virtual NatItem Item { get; set; }
        public virtual NatItemValue ItemValue { get; set; }
    }
}
