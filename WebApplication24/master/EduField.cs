using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduField
    {
        public EduField()
        {
            EduFieldSkills = new HashSet<EduFieldSkill>();
            EduPlanLongTargets = new HashSet<EduPlanLongTarget>();
        }

        public int FieldId { get; set; }
        public string FieldName { get; set; }

        public virtual ICollection<EduFieldSkill> EduFieldSkills { get; set; }
        public virtual ICollection<EduPlanLongTarget> EduPlanLongTargets { get; set; }
    }
}
