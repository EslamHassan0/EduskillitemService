using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduShortTarget
    {
        public EduShortTarget()
        {
            EduShortTargetAnalyses = new HashSet<EduShortTargetAnalysis>();
            EduShortTargetEncourages = new HashSet<EduShortTargetEncourage>();
            EduShortTargetStudyMethods = new HashSet<EduShortTargetStudyMethod>();
            EduShortTargetTeachingAids = new HashSet<EduShortTargetTeachingAid>();
        }

        public int ShortTargetId { get; set; }
        public int LongTargetId { get; set; }
        public string ShortTargetName { get; set; }
        public bool? IsApprove { get; set; }
        public DateTime? DateApprove { get; set; }
        public float? TotalEvalutionRate { get; set; }
        public string Notes { get; set; }
        public byte? Action { get; set; }

        public virtual EduPlanLongTarget LongTarget { get; set; }
        public virtual ICollection<EduShortTargetAnalysis> EduShortTargetAnalyses { get; set; }
        public virtual ICollection<EduShortTargetEncourage> EduShortTargetEncourages { get; set; }
        public virtual ICollection<EduShortTargetStudyMethod> EduShortTargetStudyMethods { get; set; }
        public virtual ICollection<EduShortTargetTeachingAid> EduShortTargetTeachingAids { get; set; }
    }
}
