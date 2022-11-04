using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiFoodGroup
    {
        public NutiFoodGroup()
        {
            NutiFoods = new HashSet<NutiFood>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<NutiFood> NutiFoods { get; set; }
    }
}
