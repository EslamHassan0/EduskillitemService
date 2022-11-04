using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidNoteDaily
    {
        public ResidNoteDaily()
        {
            ResidNoteDailyStudents = new HashSet<ResidNoteDailyStudent>();
        }

        public int DailyNoteId { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int SectionId { get; set; }
        public int? RoomId { get; set; }
        public int? CaregiverId { get; set; }
        public byte? NoteTypeId { get; set; }
        public string Note { get; set; }
        public byte? Formtype { get; set; }
        public byte Action { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual HrEmployee Caregiver { get; set; }
        public virtual ResidNoteType NoteType { get; set; }
        public virtual ResidRoom Room { get; set; }
        public virtual ResidSection Section { get; set; }
        public virtual ICollection<ResidNoteDailyStudent> ResidNoteDailyStudents { get; set; }
    }
}
