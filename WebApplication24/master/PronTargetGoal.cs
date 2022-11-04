using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronTargetGoal
    {
        public int TargetGoalId { get; set; }
        public int PlanTargetId { get; set; }
        public int GoalId { get; set; }
        public string Notes { get; set; }
        public byte? AchievementId { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual PronAchievement Achievement { get; set; }
        public virtual PronTherapeuticGoal Goal { get; set; }
        public virtual PronPlanTarget PlanTarget { get; set; }
    }
}
