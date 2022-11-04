using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class NatRom
    {
        public NatRom()
        {
            NatRomitems = new HashSet<NatRomitem>();
        }

        public int Romid { get; set; }
        public int? ParentId { get; set; }
        public string Romname { get; set; }
        public int? NaturalValue { get; set; }

        public virtual ICollection<NatRomitem> NatRomitems { get; set; }
    }
}
