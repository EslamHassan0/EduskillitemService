using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwSportPlan
    {
        public int PlanId { get; set; }
        public DateTime Date { get; set; }
        public int? SemesterId { get; set; }
        public string PlanType { get; set; }
        public string FieldName { get; set; }
        public string LongTargetName { get; set; }
        public string ShortTargetName { get; set; }
        public int LongTargetId { get; set; }
        public int ShortTargetId { get; set; }
        public int ShortTargetPlanId { get; set; }
        public int FieldId { get; set; }
        public bool IsDone { get; set; }
        public DateTime? DateAchievement { get; set; }
        public int StudentId { get; set; }
        public int? AchievementId { get; set; }
        public string AchievementName { get; set; }
        public int? Department { get; set; }
        public string Semester { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }
    }
}
