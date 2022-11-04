using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduTeachingAid
    {
        public EduTeachingAid()
        {
            EduShortTargetTeachingAids = new HashSet<EduShortTargetTeachingAid>();
        }

        public int TeachingAidsId { get; set; }
        public string TeachingAidsName { get; set; }

        public virtual ICollection<EduShortTargetTeachingAid> EduShortTargetTeachingAids { get; set; }
    }
}
