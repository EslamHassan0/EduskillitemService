using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronAssessmentOrofacialExam
    {
        public int OrofacialExamId { get; set; }
        public int AssessmentId { get; set; }
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

        public virtual PronAssessment Assessment { get; set; }
    }
}
