using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronInstruction
    {
        public PronInstruction()
        {
            PronAssessmentInstructions = new HashSet<PronAssessmentInstruction>();
        }

        public int InstructionId { get; set; }
        public string Instruction { get; set; }

        public virtual ICollection<PronAssessmentInstruction> PronAssessmentInstructions { get; set; }
    }
}
