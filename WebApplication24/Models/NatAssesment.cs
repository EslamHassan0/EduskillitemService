using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class NatAssesment
    {
        public NatAssesment()
        {
            NatAssesmentItems = new HashSet<NatAssesmentItem>();
            NatAssesmentRoms = new HashSet<NatAssesmentRom>();
        }

        public int AssesmentId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<NatAssesmentItem> NatAssesmentItems { get; set; }
        public virtual ICollection<NatAssesmentRom> NatAssesmentRoms { get; set; }
    }
}
