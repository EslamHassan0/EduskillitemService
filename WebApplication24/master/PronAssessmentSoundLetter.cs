using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronAssessmentSoundLetter
    {
        public int AssessmentSoundId { get; set; }
        public int AssessmentId { get; set; }
        public int SoundLetterId { get; set; }
        public bool IsSingle { get; set; }
        public bool IsSection { get; set; }
        public bool IsFirstWord { get; set; }
        public bool IsMidWord { get; set; }
        public bool IsEndWord { get; set; }

        public virtual PronAssessment Assessment { get; set; }
        public virtual PronSoundLetter SoundLetter { get; set; }
    }
}
