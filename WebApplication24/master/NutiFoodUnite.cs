using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiFoodUnite
    {
        public NutiFoodUnite()
        {
            NutiFoods = new HashSet<NutiFood>();
        }

        public int UniteId { get; set; }
        public string UniteName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<NutiFood> NutiFoods { get; set; }
    }
}
