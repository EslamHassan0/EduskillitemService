using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduShortTargetEncourage
    {
        public int EncourageTargId { get; set; }
        public int EncourageTypeId { get; set; }
        public int ShortTargetId { get; set; }
        public string Method { get; set; }
        public byte Action { get; set; }

        public virtual PsyEncourageType EncourageType { get; set; }
        public virtual EduShortTarget ShortTarget { get; set; }
    }
}
