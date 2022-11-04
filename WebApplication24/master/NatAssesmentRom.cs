using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatAssesmentRom
    {
        public int AssesmentRomid { get; set; }
        public int AssesmentId { get; set; }
        public int? Romid { get; set; }
        public int ItemRomId { get; set; }
        public bool? Slide { get; set; }
        public bool IsActive { get; set; }
        public int CurrentRom { get; set; }
        public int Diff { get; set; }
        public string Strength { get; set; }
        public string Notes { get; set; }
        public byte? Action { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual NatAssesment Assesment { get; set; }
        public virtual NatRomitem ItemRom { get; set; }
    }
}
