using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwRptEduEvalutionStudent
    {
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateEvalution { get; set; }
        public string Diagnosis { get; set; }
        public int? FileNo { get; set; }
        public DateTime DateRegister { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        public string SkillName { get; set; }
        public string FieldName { get; set; }
        public string Degree { get; set; }
        public string Notes { get; set; }
        public string Recommendation { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string NationalityName { get; set; }
        public int EvalutionId { get; set; }
        public string ItemName { get; set; }
        public int SkillD { get; set; }
        public int StudentId { get; set; }
    }
}
