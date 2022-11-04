using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class WsEvalutionStudent
    {
        public WsEvalutionStudent()
        {
            WsEvalutionStudentSkills = new HashSet<WsEvalutionStudentSkill>();
        }

        public int EvalutionId { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public int? Department { get; set; }
        public string Recomendation { get; set; }
        public byte Action { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte SessionId { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<WsEvalutionStudentSkill> WsEvalutionStudentSkills { get; set; }
    }
}
