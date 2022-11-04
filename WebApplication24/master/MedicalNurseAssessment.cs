using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalNurseAssessment
    {
        public int NurseAssessmnetId { get; set; }
        public int AssessmentId { get; set; }
        public string GeneralAppearance { get; set; }
        public string ChiefComplaints { get; set; }
        public string Temp { get; set; }
        public string Bp { get; set; }
        public string Pulse { get; set; }
        public string PulseCharacter { get; set; }
        public string Rr { get; set; }
        public string Spo2 { get; set; }
        public string Respcharacter { get; set; }
        public byte? SidePain { get; set; }
        public string PainScore { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string GlasgowComaScale { get; set; }
        public string VerbalResponse { get; set; }
        public string EyeOpening { get; set; }
        public string MotorResponse { get; set; }

        public virtual MedicalAssessment Assessment { get; set; }
    }
}
