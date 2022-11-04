using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwNatRptProgramStudent
    {
        public int StudentId { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public bool SexType { get; set; }
        public DateTime Birthday { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int Createby { get; set; }
        public DateTime CreateDate { get; set; }
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public byte ActionDetail { get; set; }
        public string CreateByName { get; set; }
        public int ProgStudentId { get; set; }
        public int ProgStudDetailId { get; set; }
    }
}
