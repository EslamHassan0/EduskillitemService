using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduFieldSkill
    {
        public EduFieldSkill()
        {
            EduFieldSkillItems = new HashSet<EduFieldSkillItem>();
        }

        public int SkillD { get; set; }
        public int FieldId { get; set; }
        public string SkillName { get; set; }

        public virtual EduField Field { get; set; }
        public virtual ICollection<EduFieldSkillItem> EduFieldSkillItems { get; set; }
    }
}
