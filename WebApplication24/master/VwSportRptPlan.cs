using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwSportRptPlan
    {
        public int FieldId { get; set; }
        public int? Department { get; set; }
        public int? WorkShopTypeId { get; set; }
        public string FieldName { get; set; }
        public byte Action { get; set; }
        public string LongTargetName { get; set; }
        public int LongTargetId { get; set; }
        public string ShortTargetName { get; set; }
        public int ShortTargetId { get; set; }
        public int PlanId { get; set; }
        public bool IsDone { get; set; }
        public DateTime? DateAchievement { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public int Year { get; set; }
        public int Serial { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public DateTime Birthday { get; set; }
        public bool SexType { get; set; }
        public DateTime? DateReport { get; set; }
        public int? ReportId { get; set; }
        public byte? ActionReort { get; set; }
        public byte Actionplan { get; set; }
        public int? AchievementId { get; set; }
        public string AchievementName { get; set; }
        public int? Expr1 { get; set; }
        public string Semester { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDate { get; set; }
        public int SemesterId { get; set; }
        public string Notes { get; set; }
        public string Recomendation { get; set; }
        public string WorkShopName { get; set; }
    }
}
