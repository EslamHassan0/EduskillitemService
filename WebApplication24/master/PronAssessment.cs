using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronAssessment
    {
        public PronAssessment()
        {
            PronAssessmentInstructions = new HashSet<PronAssessmentInstruction>();
            PronAssessmentMoves = new HashSet<PronAssessmentMove>();
            PronAssessmentOrofacialExams = new HashSet<PronAssessmentOrofacialExam>();
            PronAssessmentSoundLetters = new HashSet<PronAssessmentSoundLetter>();
            PronAssessmnetVocabs = new HashSet<PronAssessmnetVocab>();
            PronMedicalCases = new HashSet<PronMedicalCase>();
            PronSocailHistoryCases = new HashSet<PronSocailHistoryCase>();
        }

        public int AssessmentId { get; set; }
        public int StudentId { get; set; }
        public DateTime? Date { get; set; }
        public string BehDuringAssessment { get; set; }
        public string BegfirstWord { get; set; }
        public string HasSpeechEcholalia { get; set; }
        public string ObservationAssessment { get; set; }
        public string HascongenitalDefect { get; set; }
        public string HasVoiceDisorder { get; set; }
        public string HasVoiceDisorderDesc { get; set; }
        public string HasSuttering { get; set; }
        public string HasNasalityDisorders { get; set; }
        public string HasArticulationPhonic { get; set; }
        public string EyeContact { get; set; }
        public string EyeContactDesc { get; set; }
        public string AttentConcentration { get; set; }
        public string AttentConcentrationDesc { get; set; }
        public string ImitationMotor { get; set; }
        public string ImitationMotorDesc { get; set; }
        public string ImitationVoice { get; set; }
        public string ImitationVoiceDesc { get; set; }
        public string TurnTakingDurPlaying { get; set; }
        public string TurnTakingDurPlayingDesc { get; set; }
        public string AttractAttention { get; set; }
        public string AttractAttentionDesc { get; set; }
        public string CommthroMoveGestureDesc { get; set; }
        public string SimpleInstructionsDesc { get; set; }
        public string ReceptiveSummry { get; set; }
        public string ExpressiveSummary { get; set; }
        public string GesturesSummary { get; set; }
        public string TwoWordSentenceDesc { get; set; }
        public string TwoWordSentenceConve { get; set; }
        public string ThreeWordSentenceDesc { get; set; }
        public string ThreeWordSentenceConve { get; set; }
        public string Recomendation { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int SessionId { get; set; }
        public string RecognizeSound { get; set; }
        public string DirectionSound { get; set; }
        public string KnowSound { get; set; }
        public string CanRecoizeVoice { get; set; }
        public string IsAphasia { get; set; }
        public string IsDysarthia { get; set; }
        public string HasNasalityDisordersDesc { get; set; }
        public string HasSutteringDesc { get; set; }
        public string IsApraxia { get; set; }
        public string MoveDesc { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<PronAssessmentInstruction> PronAssessmentInstructions { get; set; }
        public virtual ICollection<PronAssessmentMove> PronAssessmentMoves { get; set; }
        public virtual ICollection<PronAssessmentOrofacialExam> PronAssessmentOrofacialExams { get; set; }
        public virtual ICollection<PronAssessmentSoundLetter> PronAssessmentSoundLetters { get; set; }
        public virtual ICollection<PronAssessmnetVocab> PronAssessmnetVocabs { get; set; }
        public virtual ICollection<PronMedicalCase> PronMedicalCases { get; set; }
        public virtual ICollection<PronSocailHistoryCase> PronSocailHistoryCases { get; set; }
    }
}
