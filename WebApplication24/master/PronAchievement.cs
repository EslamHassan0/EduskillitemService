using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronAchievement
    {
        public PronAchievement()
        {
            PronTargetGoals = new HashSet<PronTargetGoal>();
        }

        public byte AchievementId { get; set; }
        public string Achievement { get; set; }

        public virtual ICollection<PronTargetGoal> PronTargetGoals { get; set; }
    }
}
