using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuAssessmentRom
    {
        public int RomAssementId { get; set; }
        public int AssesmentId { get; set; }
        public int ItemRomId { get; set; }
        public string Evaluation { get; set; }
        public string ReEvaluation { get; set; }

        public virtual OccuAssessment Assesment { get; set; }
        public virtual NatRomitem ItemRom { get; set; }
    }
}
