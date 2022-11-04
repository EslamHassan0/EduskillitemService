using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduEvalutionStudent1
    {
        public int EvalutionId { get; set; }
        public DateTime DateEvalution { get; set; }
        public string Recommendation { get; set; }
        public int EvalutionSlilId { get; set; }
        public int SkillD { get; set; }
        public byte DegreeId { get; set; }
        public string Notes { get; set; }
    }
}
