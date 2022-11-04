using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuAssessmentFirstEva
    {
        public int AssementFirstId { get; set; }
        public int AssesmentId { get; set; }
        public string QualityDelivery { get; set; }
        public string AnyOtherDiseases { get; set; }
        public string Edema { get; set; }
        public string TherapistSessionsPtOt { get; set; }
        public string BeginSymptoms { get; set; }
        public string PainDuringRest { get; set; }
        public string Drugs { get; set; }
        public string Period { get; set; }
        public string NotesFirstAssement { get; set; }

        public virtual OccuAssessment Assesment { get; set; }
    }
}
