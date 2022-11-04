using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class PsyProblem
    {
        public PsyProblem()
        {
            PsyProblemStudentResponses = new HashSet<PsyProblemStudentResponse>();
        }

        public int ProblemId { get; set; }
        public int ProblemGroupId { get; set; }
        public string ProblemName { get; set; }

        public virtual PsyProblemGroup ProblemGroup { get; set; }
        public virtual ICollection<PsyProblemStudentResponse> PsyProblemStudentResponses { get; set; }
    }
}
