using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduShortTargetTeachingAid
    {
        public int ShortTargTeachId { get; set; }
        public int ShortTargetId { get; set; }
        public int TeachingAidsId { get; set; }
        public byte Action { get; set; }

        public virtual EduShortTarget ShortTarget { get; set; }
        public virtual EduTeachingAid TeachingAids { get; set; }
    }
}
