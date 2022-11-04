using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalPhycicanAssessment
    {
        public int PhycicanAssessmentId { get; set; }
        public int AssessmentId { get; set; }
        public bool? Orientation { get; set; }
        public bool? Paler { get; set; }
        public bool? Cyanosis { get; set; }
        public bool? Consciouslevel { get; set; }
        public bool? Cooperative { get; set; }
        public bool? Jaundice { get; set; }
        public string Others { get; set; }
        public string RespiratorySystem { get; set; }
        public string CardiovascularSystem { get; set; }
        public string Git { get; set; }
        public string Cns { get; set; }
        public string Ent { get; set; }
        public string Skin { get; set; }
        public string OphthalmicAssess { get; set; }
        public string OtherRespiratory { get; set; }
        public string Recommendations { get; set; }

        public virtual MedicalAssessment Assessment { get; set; }
    }
}
