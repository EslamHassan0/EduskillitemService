using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduShortTargetStudyMethod
    {
        public int ShortTargStudyMethId { get; set; }
        public int ShortTargetId { get; set; }
        public int StudyMethodId { get; set; }
        public byte Action { get; set; }

        public virtual EduShortTarget ShortTarget { get; set; }
        public virtual EduStudyMethod StudyMethod { get; set; }
    }
}
