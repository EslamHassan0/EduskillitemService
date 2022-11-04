using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidNoteType
    {
        public ResidNoteType()
        {
            ResidNoteDailies = new HashSet<ResidNoteDaily>();
        }

        public byte NoteTypeId { get; set; }
        public string NoteType { get; set; }

        public virtual ICollection<ResidNoteDaily> ResidNoteDailies { get; set; }
    }
}
