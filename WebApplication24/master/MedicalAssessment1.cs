using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalAssessment1
    {
        public int AssessmentId { get; set; }
        public int StudentId { get; set; }
        public int? Serial { get; set; }
        public DateTime? Date { get; set; }
        public int? CreateBy { get; set; }
        public int? Session { get; set; }
        public DateTime? CreateDate { get; set; }
        public int MedicalHistoryId { get; set; }
        public string PresentComplaints { get; set; }
        public string MedicalDiagnosis { get; set; }
        public string MainDiagnosisHistory { get; set; }
        public string LearningDifficulties { get; set; }
        public string Infections { get; set; }
        public string Convulsion { get; set; }
        public string Trauma { get; set; }
        public string SurgicalOperations { get; set; }
        public string OtherChronic { get; set; }
        public string DiseaseAllergies { get; set; }
        public string SymptomsDisability { get; set; }
        public string Notes { get; set; }
        public bool? Dm { get; set; }
        public bool? Htn { get; set; }
        public bool? Gd { get; set; }
        public bool? Pih { get; set; }
        public bool? Bleeding { get; set; }
        public bool? InfectionHealthprob { get; set; }
        public string NotesHealthProb { get; set; }
        public string ModeDelivery { get; set; }
        public string TypeDelivery { get; set; }
        public string NotesDuringDelivery { get; set; }
        public string AbGestationalAge { get; set; }
        public string AbBirthWeight { get; set; }
        public string AbResuscitation { get; set; }
        public string AbNotes { get; set; }
        public bool? FmhDm { get; set; }
        public bool? FmhHtn { get; set; }
        public bool? FmhCardiac { get; set; }
        public bool? FmhRespiratory { get; set; }
        public bool? FmhRenal { get; set; }
        public bool? FmhHaematological { get; set; }
        public string FhmOthers { get; set; }
        public string FhmHxsimilar { get; set; }
        public string DrugHxmaintenance { get; set; }
        public string DrugPlanManagement { get; set; }
        public string EventMilestone { get; set; }
        public string EventVaccinations { get; set; }
        public string EventInfections { get; set; }
        public string EventConvulsion { get; set; }
        public string EventTrauma { get; set; }
        public string EventSurgical { get; set; }
        public string EventOtherChronic { get; set; }
        public string EventSymptoms { get; set; }
        public string EventNotes { get; set; }
        public string SocialHParentsStatus { get; set; }
        public string SocialHistory { get; set; }
        public string PsychoTraumeInFyear { get; set; }
        public string PsychoTraumeAfter5Fyear { get; set; }
        public string PsychologicalHistory { get; set; }
        public int NurseAssessmnetId { get; set; }
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
        public int PhycicanAssessmentId { get; set; }
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
    }
}
