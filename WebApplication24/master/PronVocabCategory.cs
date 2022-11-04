using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronVocabCategory
    {
        public PronVocabCategory()
        {
            PronVocabs = new HashSet<PronVocab>();
        }

        public int VocabCategoryId { get; set; }
        public string VocabCategory { get; set; }

        public virtual ICollection<PronVocab> PronVocabs { get; set; }
    }
}
