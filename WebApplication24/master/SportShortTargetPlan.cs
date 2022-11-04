using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class SportShortTargetPlan
    {
        public int ShortTargetPlanId { get; set; }
        public int ShortTargetId { get; set; }
        public int? SemesterId { get; set; }
        public int PlanId { get; set; }
        public bool IsDone { get; set; }
        public DateTime? DateAchievement { get; set; }
        public int? AchievementId { get; set; }
        public byte? Action { get; set; }
        public string Notes { get; set; }

        public virtual SportAchievement Achievement { get; set; }
        public virtual SportPlan Plan { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual SportShortTarget ShortTarget { get; set; }
    }
}
