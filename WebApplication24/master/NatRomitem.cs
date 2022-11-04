using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatRomitem
    {
        public NatRomitem()
        {
            NatAssesmentRoms = new HashSet<NatAssesmentRom>();
            OccuAssessmentRoms = new HashSet<OccuAssessmentRom>();
        }

        public int ItemRomId { get; set; }
        public int Romid { get; set; }
        public string ItemRomName { get; set; }
        public string NormalValue { get; set; }
        public int? StudentId { get; set; }

        public virtual NatRom Rom { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<NatAssesmentRom> NatAssesmentRoms { get; set; }
        public virtual ICollection<OccuAssessmentRom> OccuAssessmentRoms { get; set; }
    }
}
