using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwEduRptResponsePlanStudent
    {
        public string FieldName { get; set; }
        public int? LongTargetId { get; set; }
        public string LongTargetName { get; set; }
        public int? FieldId { get; set; }
        public int? PlanStudyId { get; set; }
        public int? StudentId { get; set; }
        public int? SemesterId { get; set; }
        public DateTime? PlanDateFrom { get; set; }
        public DateTime? PlanDateTo { get; set; }
        public bool? IsApproveSuperVisor { get; set; }
        public string Semester { get; set; }
        public int? Year { get; set; }
        public string StudentNameArabic { get; set; }
        public DateTime? Birthday { get; set; }
        public int? FileNo { get; set; }
        public int? Yearstart { get; set; }
        public int? ShortTargetId { get; set; }
        public string ShortTargetName { get; set; }
        public string StudentNameEnglish { get; set; }
        public DateTime? DateRegister { get; set; }
        public string MedicalDiagnosis { get; set; }
        public string Idnumber { get; set; }
        public string Report { get; set; }
        public DateTime? CreateDate { get; set; }
        public float? TotalEvalutionRate { get; set; }
        public string NoteShortTarg { get; set; }
        public string ResponseName { get; set; }
        public byte Value { get; set; }
        public byte RepeatNo { get; set; }
        public int? PlanReportId { get; set; }
        public string AnalysisName { get; set; }
        public string TeacherName { get; set; }
        public string Supervisour { get; set; }
    }
}
