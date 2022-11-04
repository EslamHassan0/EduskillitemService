using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidNoteComunity
    {
        public int ComunNoteId { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int StudentId { get; set; }
        public byte? ComunTypeId { get; set; }
        public string Notes { get; set; }
        public byte? Action { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SessionId { get; set; }

        public virtual ResidComunType ComunType { get; set; }
        public virtual Student Student { get; set; }
    }
}
