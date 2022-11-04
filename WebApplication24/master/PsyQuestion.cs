using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PsyQuestion
    {
        public PsyQuestion()
        {
            PsyCaseStudies = new HashSet<PsyCaseStudy>();
        }

        public int QuestionId { get; set; }
        public string Question { get; set; }

        public virtual ICollection<PsyCaseStudy> PsyCaseStudies { get; set; }
    }
}
