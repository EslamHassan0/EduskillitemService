using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduStudyMethod
    {
        public EduStudyMethod()
        {
            EduShortTargetStudyMethods = new HashSet<EduShortTargetStudyMethod>();
        }

        public int StudyMethodId { get; set; }
        public string StudyMethodName { get; set; }

        public virtual ICollection<EduShortTargetStudyMethod> EduShortTargetStudyMethods { get; set; }
    }
}
