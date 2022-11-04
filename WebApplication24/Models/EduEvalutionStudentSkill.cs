using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduEvalutionStudentSkill
    {
        public int EvalutionSlilId { get; set; }
        public int EvalutionId { get; set; }
        public int SkillD { get; set; }
        public byte DegreeId { get; set; }
        public string Notes { get; set; }

        public virtual EduEvalutionDegree Degree { get; set; }
        public virtual EduEvalutionStudent Evalution { get; set; }
        public virtual EduFieldSkill SkillDNavigation { get; set; }
    }
}
