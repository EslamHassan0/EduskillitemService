using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduPlanLongTarget
    {
        public EduPlanLongTarget()
        {
            EduShortTargets = new HashSet<EduShortTarget>();
        }

        public int LongTargetId { get; set; }
        public string LongTargetName { get; set; }
        public int FieldId { get; set; }
        public int? PlanStudyId { get; set; }
        public byte? Action { get; set; }

        public virtual EduField Field { get; set; }
        public virtual EduPlanStudy PlanStudy { get; set; }
        public virtual ICollection<EduShortTarget> EduShortTargets { get; set; }
    }
}
