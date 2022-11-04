using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class SportTargetAchievement
    {
        public int TargetAchievementId { get; set; }
        public int AchievementId { get; set; }
        public int ShortTargetPlanId { get; set; }

        public virtual SportAchievement Achievement { get; set; }
    }
}
