using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronTherapeuticGoal
    {
        public PronTherapeuticGoal()
        {
            PronTargetGoals = new HashSet<PronTargetGoal>();
        }

        public int GoalId { get; set; }
        public string Goals { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<PronTargetGoal> PronTargetGoals { get; set; }
    }
}
