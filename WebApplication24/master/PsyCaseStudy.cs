using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PsyCaseStudy
    {
        public int CaseStudyId { get; set; }
        public int? StudentId { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }

        public virtual PsyQuestion Question { get; set; }
        public virtual Student Student { get; set; }
    }
}
