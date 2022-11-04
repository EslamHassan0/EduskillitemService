using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidNoteDailyStudent
    {
        public int StudentNoteId { get; set; }
        public int DailyNoteId { get; set; }
        public int StudentId { get; set; }

        public virtual ResidNoteDaily DailyNote { get; set; }
        public virtual Student Student { get; set; }
    }
}
