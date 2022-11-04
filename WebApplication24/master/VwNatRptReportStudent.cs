using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwNatRptReportStudent
    {
        public int ReportId { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public string Details { get; set; }
        public DateTime CreateDate { get; set; }
        public int Createby { get; set; }
        public string CreateByName { get; set; }
        public int Serial { get; set; }
        public bool SexType { get; set; }
        public DateTime Birthday { get; set; }
        public string StudentNameEnglish { get; set; }
        public string StudentNameArabic { get; set; }
    }
}
