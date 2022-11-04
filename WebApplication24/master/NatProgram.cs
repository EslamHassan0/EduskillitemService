using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatProgram
    {
        public NatProgram()
        {
            NatProgStudentDetails = new HashSet<NatProgStudentDetail>();
        }

        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public byte? Action { get; set; }
        public int? Createby { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte? SessionId { get; set; }

        public virtual ICollection<NatProgStudentDetail> NatProgStudentDetails { get; set; }
    }
}
