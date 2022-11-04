using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwNatRptAssessmentRom
    {
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
        public string Romname { get; set; }
        public string Promname { get; set; }
        public string Gromname { get; set; }
        public int AssesmentId { get; set; }
        public int? ParentId { get; set; }
        public int? GrandId { get; set; }
        public int? NaturalValue { get; set; }
        public string ItemRomName { get; set; }
        public string NormalValue { get; set; }
    }
}
