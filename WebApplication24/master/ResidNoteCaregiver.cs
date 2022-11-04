using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidNoteCaregiver
    {
        public int NoteCaregiverId { get; set; }
        public int CaregiverId { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string TypeNote { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual HrEmployee Caregiver { get; set; }
    }
}
