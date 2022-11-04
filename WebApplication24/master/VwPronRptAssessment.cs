using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwPronRptAssessment
    {
        public int StudentId { get; set; }
        public int Serial { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public int? OrofacialExamId { get; set; }
        public string Lips { get; set; }
        public string LipsDescrib { get; set; }
        public string Jaws { get; set; }
        public string JawsDescrib { get; set; }
        public string Softpalate { get; set; }
        public string SoftPalateDescrib { get; set; }
        public string Velar { get; set; }
        public string VelarDescrib { get; set; }
        public string Tonsils { get; set; }
        public string TonsilsDescrib { get; set; }
        public string Teeth { get; set; }
        public string TeethDescrib { get; set; }
        public string NasalCavity { get; set; }
        public string NasalCavityDescrib { get; set; }
        public string Tongue { get; set; }
        public string TongueDescrib { get; set; }
        public string MovementLips { get; set; }
        public string MovementVelar { get; set; }
        public string MovementSoft { get; set; }
        public string Palate { get; set; }
        public string ControlThroat { get; set; }
        public string MovBackTongue { get; set; }
        public int AssessmentId { get; set; }
        public DateTime? Date { get; set; }
        public string BehDuringAssessment { get; set; }
        public string BegfirstWord { get; set; }
        public string HasSpeechEcholalia { get; set; }
        public string ObservationAssessment { get; set; }
        public string HascongenitalDefect { get; set; }
        public string HasVoiceDisorder { get; set; }
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
        public string Name { get; set; }
        public string HasNasalityDisordersDesc { get; set; }
        public string HasSutteringDesc { get; set; }
        public string IsApraxia { get; set; }
        public string MoveDesc { get; set; }
    }
}
