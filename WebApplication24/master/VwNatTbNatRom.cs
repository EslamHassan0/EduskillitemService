using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwNatTbNatRom
    {
        public int Romid { get; set; }
        public int? ParentId { get; set; }
        public string Romname { get; set; }
        public int? NaturalValue { get; set; }
        public int? Department { get; set; }
        public int GparentId { get; set; }
        public string PromName { get; set; }
        public int ItemRomId { get; set; }
        public string ItemRomName { get; set; }
        public string NormalValue { get; set; }
    }
}
