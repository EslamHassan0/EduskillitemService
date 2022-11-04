using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronSoundLetter
    {
        public PronSoundLetter()
        {
            PronAssessmentSoundLetters = new HashSet<PronAssessmentSoundLetter>();
        }

        public int SoundLetterId { get; set; }
        public string LetterName { get; set; }

        public virtual ICollection<PronAssessmentSoundLetter> PronAssessmentSoundLetters { get; set; }
    }
}
