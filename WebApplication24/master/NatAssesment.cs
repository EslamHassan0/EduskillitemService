using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatAssesment
    {
        public NatAssesment()
        {
            NatAssesmentItems = new HashSet<NatAssesmentItem>();
            NatAssesmentRoms = new HashSet<NatAssesmentRom>();
        }

        public int AssesmentId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }
        public string NoteNervousSys { get; set; }
        public string NoteContact { get; set; }
        public string NoteMuscleTone { get; set; }
        public string NoteRom { get; set; }
        public string NoteMmt { get; set; }
        public string NoteDeepTendonR { get; set; }
        public string NoteFunassessment { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<NatAssesmentItem> NatAssesmentItems { get; set; }
        public virtual ICollection<NatAssesmentRom> NatAssesmentRoms { get; set; }
    }
}
