using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduFieldSkillItem
    {
        public EduFieldSkillItem()
        {
            EduEvalutionStudentSkills = new HashSet<EduEvalutionStudentSkill>();
        }

        public int SkillItemId { get; set; }
        public int SkillD { get; set; }
        public string ItemName { get; set; }

        public virtual EduFieldSkill SkillDNavigation { get; set; }
        public virtual ICollection<EduEvalutionStudentSkill> EduEvalutionStudentSkills { get; set; }
    }
}
