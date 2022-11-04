using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NatProgStudentDetail
    {
        public int ProgStudDetailId { get; set; }
        public int ProgStudentId { get; set; }
        public int ProgramId { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int Createby { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual NatProgStudent ProgStudent { get; set; }
        public virtual NatProgram Program { get; set; }
    }
}
