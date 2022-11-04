using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class WsEvalutionStudentSkill
    {
        public int EvalutionSkilId { get; set; }
        public int EvalutionId { get; set; }
        public int SkilId { get; set; }
        public int DegreeId { get; set; }
        public byte Action { get; set; }
        public string Notes { get; set; }

        public virtual SportAchievement Degree { get; set; }
        public virtual WsEvalutionStudent Evalution { get; set; }
        public virtual WsSkilI Skil { get; set; }
    }
}
