using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class PsyProblemStudent1
    {
        public int ProblemStudentId { get; set; }
        public DateTime Date { get; set; }
        public float TotalDegree { get; set; }
        public int ProblemStudentRespId { get; set; }
        public int ProblemId { get; set; }
        public bool Result { get; set; }
    }
}
