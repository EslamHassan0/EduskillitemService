using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduEvalutionStudent
    {
        public EduEvalutionStudent()
        {
            EduEvalutionStudentSkills = new HashSet<EduEvalutionStudentSkill>();
        }

        public int EvalutionId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateEvalution { get; set; }
        public string Recommendation { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<EduEvalutionStudentSkill> EduEvalutionStudentSkills { get; set; }
    }
}
