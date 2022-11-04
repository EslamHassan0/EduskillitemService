using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwSportRptEvalution
    {
        public int FieldId { get; set; }
        public int? Department { get; set; }
        public int? WorkShopTypeId { get; set; }
        public string FieldName { get; set; }
        public byte Action { get; set; }
        public string SkillName { get; set; }
        public int SkilId { get; set; }
        public int EvalutionSkilId { get; set; }
        public int EvalutionId { get; set; }
        public int DegreeId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Recomendation { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public bool SexType { get; set; }
        public DateTime Birthday { get; set; }
        public byte ActionEvaluation { get; set; }
        public string DegreeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreateByName { get; set; }
        public int CreatedBy { get; set; }
        public string Notes { get; set; }
    }
}
