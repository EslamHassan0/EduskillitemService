using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwPronAssessmentSoundLetter
    {
        public string LetterName { get; set; }
        public int AssessmentSoundId { get; set; }
        public int AssessmentId { get; set; }
        public int SoundLetterId { get; set; }
        public bool IsSingle { get; set; }
        public bool IsSection { get; set; }
        public bool FirstWord { get; set; }
        public bool MidWord { get; set; }
        public bool EndWord { get; set; }
    }
}
