using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronVocab
    {
        public PronVocab()
        {
            PronAssessmnetVocabs = new HashSet<PronAssessmnetVocab>();
        }

        public int VocabId { get; set; }
        public int VocabCategoryId { get; set; }
        public string Vocabularies { get; set; }

        public virtual PronVocabCategory VocabCategory { get; set; }
        public virtual ICollection<PronAssessmnetVocab> PronAssessmnetVocabs { get; set; }
    }
}
