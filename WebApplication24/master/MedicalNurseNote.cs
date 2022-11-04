using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalNurseNote
    {
        public int NurseNoteId { get; set; }
        public int StudentId { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte SessionId { get; set; }

        public virtual Student Student { get; set; }
    }
}
