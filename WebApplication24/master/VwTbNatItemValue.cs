using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwTbNatItemValue
    {
        public int ItemGrpId { get; set; }
        public string ItemName { get; set; }
        public int? ItemValueId { get; set; }
        public string GroupName { get; set; }
        public int ItemValue { get; set; }
        public byte? DataType { get; set; }
    }
}
