using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduEvalutionDegree
    {
        public EduEvalutionDegree()
        {
            EduEvalutionStudentSkills = new HashSet<EduEvalutionStudentSkill>();
        }

        public byte DegreeId { get; set; }
        public string Degree { get; set; }

        public virtual ICollection<EduEvalutionStudentSkill> EduEvalutionStudentSkills { get; set; }
    }
}
