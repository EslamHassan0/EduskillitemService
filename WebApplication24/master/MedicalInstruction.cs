using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalInstruction
    {
        public int InstructionId { get; set; }
        public string Instruction { get; set; }
        public byte Action { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte SessionId { get; set; }
    }
}
