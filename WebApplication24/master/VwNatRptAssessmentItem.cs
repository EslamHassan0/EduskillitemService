using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwNatRptAssessmentItem
    {
        public string GroupName { get; set; }
        public string ItemValue { get; set; }
        public DateTime Date { get; set; }
        public int AssesmentId { get; set; }
        public string Notes { get; set; }
        public string NoteNervousSys { get; set; }
        public string NoteContact { get; set; }
        public string NoteMuscleTone { get; set; }
        public string NoteRom { get; set; }
        public string NoteMmt { get; set; }
        public string NoteDeepTendonR { get; set; }
        public string NoteFunassessment { get; set; }
        public byte Action { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public int ItemGrpId { get; set; }
        public int ItemId { get; set; }
        public int Serial { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public DateTime Birthday { get; set; }
        public bool SexType { get; set; }
        public string SerialPrev { get; set; }
        public string Idnumber { get; set; }
        public int StudentId { get; set; }
        public string ItemName { get; set; }
    }
}
