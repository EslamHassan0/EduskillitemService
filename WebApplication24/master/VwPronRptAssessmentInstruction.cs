using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwPronRptAssessmentInstruction
    {
        public int AssessmentInstId { get; set; }
        public int AssessmentId { get; set; }
        public int InstructionId { get; set; }
        public string Result { get; set; }
        public string Instruction { get; set; }
    }
}
