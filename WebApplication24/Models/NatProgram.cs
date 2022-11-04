using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class NatProgram
    {
        public NatProgram()
        {
            NatProgStudentDetails = new HashSet<NatProgStudentDetail>();
        }

        public int ProgramId { get; set; }
        public string ProgramName { get; set; }

        public virtual ICollection<NatProgStudentDetail> NatProgStudentDetails { get; set; }
    }
}
