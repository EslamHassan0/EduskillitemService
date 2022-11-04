using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronMedicalCase
    {
        public int MedicalCaseId { get; set; }
        public int StudentId { get; set; }
        public int? AssessmentId { get; set; }
        public string CircumstanceBirth { get; set; }
        public byte? MotherAge { get; set; }
        public string TakeMedicine { get; set; }
        public string TakeSpecMedicine { get; set; }
        public string Description { get; set; }
        public string Surgery { get; set; }
        public string Motor { get; set; }
        public string Cognitive { get; set; }
        public string DescriptionIssueStatus { get; set; }
        public string Visual { get; set; }
        public string Hearing { get; set; }
        public string BreathingProblems { get; set; }
        public string FamilyMemhasdiagnosis { get; set; }
        public string SwallowingProb { get; set; }
        public string RunnySaliva { get; set; }
        public string CrampsEpilepsy { get; set; }
        public string Sitting { get; set; }
        public string Crawling { get; set; }
        public string Walking { get; set; }
        public string HowProblemStarted { get; set; }
        public string HowGuardians { get; set; }
        public string DescribedMotoProb { get; set; }
        public string NoteMotor { get; set; }
        public string TakeMedicineDescrib { get; set; }
        public string TakeSpecMedicineDescrib { get; set; }
        public string SurgeryDescrib { get; set; }
        public string CognitiveDescrib { get; set; }
        public string VisualDescrib { get; set; }
        public string HearingDescrib { get; set; }
        public string BreathingProblemsDescrib { get; set; }
        public string FamilyMemhasdiagnosisDescrib { get; set; }
        public string SwallowingProbDescrib { get; set; }
        public string RunnySalivaDescrib { get; set; }
        public string CrampsEpilepsyDescrib { get; set; }
        public string SittingDescrib { get; set; }
        public string CrawlingDescrib { get; set; }
        public string WalkingDescrib { get; set; }

        public virtual PronAssessment Assessment { get; set; }
    }
}
