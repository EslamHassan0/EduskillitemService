using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduShortTargetAnalysisResponse
    {
        public int ResponseAnalysisId { get; set; }
        public DateTime Date { get; set; }
        public int ShortTargetAnalysisId { get; set; }
        public byte ResponseValueId { get; set; }
        public int Degree { get; set; }
        public byte RepeatNo { get; set; }
        public string Notes { get; set; }
        public byte? Action { get; set; }
        public int? CreateBy { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual EduResponseValue ResponseValue { get; set; }
        public virtual EduShortTargetAnalysis ShortTargetAnalysis { get; set; }
    }
}
