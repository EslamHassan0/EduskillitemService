using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidAssetRom
    {
        public int AssetRomId { get; set; }
        public int AssetId { get; set; }
        public int RoomId { get; set; }
        public int? Qty { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual ResidAsset Asset { get; set; }
        public virtual ResidRoom Room { get; set; }
    }
}
