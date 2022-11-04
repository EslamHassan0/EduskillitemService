using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
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
        public string NoteEpisodic { get; set; }
        public string NoteDefineCaseProb { get; set; }
        public string NoteTribal { get; set; }
        public string NoteRedFlag { get; set; }
        public string NoteAfterStimuli { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<PsyProblemStudentResponse> PsyProblemStudentResponses { get; set; }
    }
}
