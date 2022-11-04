using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class PsyEncourageType
    {
        public PsyEncourageType()
        {
            EduShortTargetEncourages = new HashSet<EduShortTargetEncourage>();
            PsyPlanModifiBehavMethEncrages = new HashSet<PsyPlanModifiBehavMethEncrage>();
        }

        public int EncourageTypeId { get; set; }
        public string EncourageName { get; set; }

        public virtual ICollection<EduShortTargetEncourage> EduShortTargetEncourages { get; set; }
        public virtual ICollection<PsyPlanModifiBehavMethEncrage> PsyPlanModifiBehavMethEncrages { get; set; }
    }
}
