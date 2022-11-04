using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronAssessmentMove
    {
        public int AssessmentMoveId { get; set; }
        public int AssessmentId { get; set; }
        public int MovementId { get; set; }
        public string Result { get; set; }

        public virtual PronAssessment Assessment { get; set; }
        public virtual PronMovement Movement { get; set; }
    }
}
