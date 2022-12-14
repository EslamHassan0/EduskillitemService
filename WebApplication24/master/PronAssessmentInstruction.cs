using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronAssessmentInstruction
    {
        public int AssessmentInstId { get; set; }
        public int InstructionId { get; set; }
        public int AssessmentId { get; set; }
        public string Result { get; set; }

        public virtual PronAssessment Assessment { get; set; }
        public virtual PronInstruction Instruction { get; set; }
    }
}
