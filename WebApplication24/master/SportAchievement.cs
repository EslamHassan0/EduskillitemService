using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class SportAchievement
    {
        public SportAchievement()
        {
            SportShortTargetPlans = new HashSet<SportShortTargetPlan>();
            SportTargetAchievements = new HashSet<SportTargetAchievement>();
            WsEvalutionStudentSkills = new HashSet<WsEvalutionStudentSkill>();
        }

        public int AchievementId { get; set; }
        public string AchievementName { get; set; }
        public int? Department { get; set; }

        public virtual ICollection<SportShortTargetPlan> SportShortTargetPlans { get; set; }
        public virtual ICollection<SportTargetAchievement> SportTargetAchievements { get; set; }
        public virtual ICollection<WsEvalutionStudentSkill> WsEvalutionStudentSkills { get; set; }
    }
}
