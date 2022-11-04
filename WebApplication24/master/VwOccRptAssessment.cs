using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwOccRptAssessment
    {
        public int AssesmentId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int CreateBy { get; set; }
        public string Action { get; set; }
        public DateTime CreateDate { get; set; }
        public string Evaluation { get; set; }
        public string ReEvaluation { get; set; }
        public int ItemRomId { get; set; }
        public int Romid { get; set; }
        public string ItemRomName { get; set; }
        public string NormalValue { get; set; }
        public string Romname { get; set; }
        public string Promname { get; set; }
        public int? Department { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public bool SexType { get; set; }
        public DateTime Birthday { get; set; }
        public string CreateByUser { get; set; }
    }
}
