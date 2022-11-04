using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidRoom
    {
        public ResidRoom()
        {
            ResidAbsenceStudents = new HashSet<ResidAbsenceStudent>();
            ResidAssetRoms = new HashSet<ResidAssetRom>();
            ResidNoteDailies = new HashSet<ResidNoteDaily>();
            ResidNoteRoms = new HashSet<ResidNoteRom>();
            ResidStudRooms = new HashSet<ResidStudRoom>();
        }

        public int RoomId { get; set; }
        public int SectionId { get; set; }
        public string RoomName { get; set; }
        public int CareGiverId { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual ResidSection Section { get; set; }
        public virtual ICollection<ResidAbsenceStudent> ResidAbsenceStudents { get; set; }
        public virtual ICollection<ResidAssetRom> ResidAssetRoms { get; set; }
        public virtual ICollection<ResidNoteDaily> ResidNoteDailies { get; set; }
        public virtual ICollection<ResidNoteRom> ResidNoteRoms { get; set; }
        public virtual ICollection<ResidStudRoom> ResidStudRooms { get; set; }
    }
}
