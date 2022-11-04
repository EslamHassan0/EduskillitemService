using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class SportField
    {
        public SportField()
        {
            SportLongTargets = new HashSet<SportLongTarget>();
            WsSkilIs = new HashSet<WsSkilI>();
        }

        public int FieldId { get; set; }
        public int? Department { get; set; }
        public int? WorkShopTypeId { get; set; }
        public string FieldName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual WorkShopType WorkShopType { get; set; }
        public virtual ICollection<SportLongTarget> SportLongTargets { get; set; }
        public virtual ICollection<WsSkilI> WsSkilIs { get; set; }
    }
}
