using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidAbsenceStudent
    {
        public int AbsenceStudentId { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public int RoomId { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual ResidRoom Room { get; set; }
        public virtual Student Student { get; set; }
    }
}
