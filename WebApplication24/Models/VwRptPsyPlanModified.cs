using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class VwRptPsyPlanModified
    {
        public int? BehavAnalysisItemId { get; set; }
        public int? Parent { get; set; }
        public string ParentItemName { get; set; }
        public string ChildItemName { get; set; }
        public int? Expr2 { get; set; }
        public int PlanBehaviorId { get; set; }
        public string TargetPlane { get; set; }
        public DateTime PostDate { get; set; }
        public string Examineby { get; set; }
        public string MethodName { get; set; }
        public int StudentId { get; set; }
        public int BehaviorFormId { get; set; }
        public string StudentNameArabic { get; set; }
        public bool SexType { get; set; }
        public DateTime Birthday { get; set; }
    }
}
