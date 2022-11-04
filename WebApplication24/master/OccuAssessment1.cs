using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuAssessment1
    {
        public int AssesmentId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public bool IsFirstAssement { get; set; }
        public byte SessionId { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string Action { get; set; }
        public int AssementFirstId { get; set; }
        public string QualityDelivery { get; set; }
        public string AnyOtherDiseases { get; set; }
        public string Edema { get; set; }
        public string TherapistSessionsPtOt { get; set; }
        public string BeginSymptoms { get; set; }
        public string PainDuringRest { get; set; }
        public string Drugs { get; set; }
        public string Period { get; set; }
        public string NotesFirstAssement { get; set; }
    }
}
