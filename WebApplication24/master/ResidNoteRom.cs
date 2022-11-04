using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidNoteRom
    {
        public int NoteRomId { get; set; }
        public int RoomId { get; set; }
        public int AssetId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string ProcesType { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual ResidAsset Asset { get; set; }
        public virtual ResidRoom Room { get; set; }
    }
}
