using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class WsSkilI
    {
        public WsSkilI()
        {
            WsEvalutionStudentSkills = new HashSet<WsEvalutionStudentSkill>();
        }

        public int SkilId { get; set; }
        public int FieldId { get; set; }
        public string SkillName { get; set; }
        public byte? Action { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte? SessionId { get; set; }

        public virtual SportField Field { get; set; }
        public virtual ICollection<WsEvalutionStudentSkill> WsEvalutionStudentSkills { get; set; }
    }
}
