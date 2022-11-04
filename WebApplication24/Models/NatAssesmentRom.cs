using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class NatAssesmentRom
    {
        public int AssesmentRomid { get; set; }
        public int AssesmentId { get; set; }
        public int ItemRomId { get; set; }
        public bool? Slide { get; set; }
        public bool IsActive { get; set; }
        public int CurrentRom { get; set; }
        public int Diff { get; set; }
        public string Notes { get; set; }

        public virtual NatAssesment Assesment { get; set; }
        public virtual NatRomitem ItemRom { get; set; }
    }
}
