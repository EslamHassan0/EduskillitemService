using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidAsset
    {
        public ResidAsset()
        {
            ResidAssetRoms = new HashSet<ResidAssetRom>();
            ResidNoteRoms = new HashSet<ResidNoteRom>();
        }

        public int AssetId { get; set; }
        public string AssetName { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual ICollection<ResidAssetRom> ResidAssetRoms { get; set; }
        public virtual ICollection<ResidNoteRom> ResidNoteRoms { get; set; }
    }
}
