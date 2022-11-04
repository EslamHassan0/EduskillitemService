using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class NatRomitem
    {
        public NatRomitem()
        {
            NatAssesmentRoms = new HashSet<NatAssesmentRom>();
        }

        public int ItemRomId { get; set; }
        public int Romid { get; set; }
        public string ItemRomName { get; set; }

        public virtual NatRom Rom { get; set; }
        public virtual ICollection<NatAssesmentRom> NatAssesmentRoms { get; set; }
    }
}
