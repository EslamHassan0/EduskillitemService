using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PsyProblemStudentResponse
    {
        public int ProblemStudentRespId { get; set; }
        public int ProblemStudentId { get; set; }
        public int ProblemId { get; set; }
        public bool Result { get; set; }

        public virtual PsyProblem Problem { get; set; }
        public virtual PsyProblemStudent ProblemStudent { get; set; }
    }
}
