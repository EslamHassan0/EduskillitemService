using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwPronRptPronAssessmnetVocab
    {
        public int AssessmnetVocabId { get; set; }
        public int VocabId { get; set; }
        public int AssessmentId { get; set; }
        public bool IsUnderstand { get; set; }
        public bool IsExpress { get; set; }
        public bool IsGesture { get; set; }
        public int VocabCategoryId { get; set; }
        public string Vocabularies { get; set; }
        public string VocabCategory { get; set; }
    }
}
