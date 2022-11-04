using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class PsyProblemGroup
    {
        public PsyProblemGroup()
        {
            PsyProblems = new HashSet<PsyProblem>();
        }

        public int ProblemGroupId { get; set; }
        public string ProbGroupName { get; set; }

        public virtual ICollection<PsyProblem> PsyProblems { get; set; }
    }
}
