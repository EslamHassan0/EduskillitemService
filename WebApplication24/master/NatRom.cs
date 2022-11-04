using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatRom
    {
        public NatRom()
        {
            NatRomitems = new HashSet<NatRomitem>();
            OccuEvaluationValues = new HashSet<OccuEvaluationValue>();
        }

        public int Romid { get; set; }
        public int? ParentId { get; set; }
        public string Romname { get; set; }
        public int? NaturalValue { get; set; }
        public int? Department { get; set; }

        public virtual ICollection<NatRomitem> NatRomitems { get; set; }
        public virtual ICollection<OccuEvaluationValue> OccuEvaluationValues { get; set; }
    }
}
