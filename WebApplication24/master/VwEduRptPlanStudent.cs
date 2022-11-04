using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwEduRptPlanStudent
    {
        public string FieldName { get; set; }
        public int LongTargetId { get; set; }
        public string LongTargetName { get; set; }
        public int FieldId { get; set; }
        public int PlanStudyId { get; set; }
        public int StudentId { get; set; }
        public int? SemesterId { get; set; }
        public DateTime PlanDateFrom { get; set; }
        public DateTime PlanDateTo { get; set; }
        public bool IsApproveSuperVisor { get; set; }
        public string Semester { get; set; }
        public int? Year { get; set; }
        public string StudentNameArabic { get; set; }
        public DateTime Birthday { get; set; }
        public int? FileNo { get; set; }
        public int? Yearstart { get; set; }
        public int ShortTargetId { get; set; }
        public string ShortTargetName { get; set; }
        public string StudyMethodName { get; set; }
        public string TeachingAidsName { get; set; }
        public string StudentNameEnglish { get; set; }
        public DateTime DateRegister { get; set; }
        public string MedicalDiagnosis { get; set; }
        public string Idnumber { get; set; }
        public string Encourage { get; set; }
        public bool? IsApprove { get; set; }
        public string EmployeeName { get; set; }
        public string Supervisour { get; set; }
        public string NotesLongTarget { get; set; }
    }
}
