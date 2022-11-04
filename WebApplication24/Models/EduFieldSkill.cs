using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduFieldSkill
    {
        public EduFieldSkill()
        {
            EduEvalutionStudentSkills = new HashSet<EduEvalutionStudentSkill>();
            EduFieldSkillItems = new HashSet<EduFieldSkillItem>();
        }

        public int SkillD { get; set; }
        public int FieldId { get; set; }
        public string SkillName { get; set; }

        public virtual EduField Field { get; set; }
        public virtual ICollection<EduEvalutionStudentSkill> EduEvalutionStudentSkills { get; set; }
        public virtual ICollection<EduFieldSkillItem> EduFieldSkillItems { get; set; }
    }
}
