using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatStudentReport
    {
        public int ReportId { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public string Details { get; set; }
        public byte Action { get; set; }
        public int Createby { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual User CreatebyNavigation { get; set; }
        public virtual Student Student { get; set; }
    }
}
