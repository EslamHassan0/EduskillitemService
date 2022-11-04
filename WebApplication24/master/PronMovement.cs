using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronMovement
    {
        public PronMovement()
        {
            PronAssessmentMoves = new HashSet<PronAssessmentMove>();
        }

        public int MovementId { get; set; }
        public int MoveCategoryId { get; set; }
        public string Movement { get; set; }

        public virtual PronMoveCategory MoveCategory { get; set; }
        public virtual ICollection<PronAssessmentMove> PronAssessmentMoves { get; set; }
    }
}
