using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatProgStudent
    {
        public NatProgStudent()
        {
            NatProgStudentDetails = new HashSet<NatProgStudentDetail>();
        }

        public int ProgStudentId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int Createby { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<NatProgStudentDetail> NatProgStudentDetails { get; set; }
    }
}
