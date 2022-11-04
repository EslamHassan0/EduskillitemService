using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuAssessment
    {
        public OccuAssessment()
        {
            OccuAssessmentFirstEvas = new HashSet<OccuAssessmentFirstEva>();
            OccuAssessmentRoms = new HashSet<OccuAssessmentRom>();
        }

        public int AssesmentId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public bool IsFirstAssement { get; set; }
        public byte SessionId { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string Action { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<OccuAssessmentFirstEva> OccuAssessmentFirstEvas { get; set; }
        public virtual ICollection<OccuAssessmentRom> OccuAssessmentRoms { get; set; }
    }
}
