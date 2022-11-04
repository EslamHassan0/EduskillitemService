using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class PsyProblemStudent
    {
        public PsyProblemStudent()
        {
            PsyProblemStudentResponses = new HashSet<PsyProblemStudentResponse>();
        }

        public int ProblemStudentId { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public float TotalDegree { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<PsyProblemStudentResponse> PsyProblemStudentResponses { get; set; }
    }
}
