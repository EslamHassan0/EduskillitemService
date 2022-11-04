using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronAssessmnetVocab
    {
        public int AssessmnetVocabId { get; set; }
        public int VocabId { get; set; }
        public int AssessmentId { get; set; }
        public bool IsUnderstand { get; set; }
        public bool IsExpress { get; set; }
        public bool IsGesture { get; set; }

        public virtual PronAssessment Assessment { get; set; }
        public virtual PronVocab Vocab { get; set; }
    }
}
