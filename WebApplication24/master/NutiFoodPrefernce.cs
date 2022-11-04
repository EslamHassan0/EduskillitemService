using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiFoodPrefernce
    {
        public NutiFoodPrefernce()
        {
            NutiFoodPrefernceDets = new HashSet<NutiFoodPrefernceDet>();
        }

        public int FodPrefernceId { get; set; }
        public int StudentId { get; set; }
        public string Notes { get; set; }
        public string Attachment { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int SessionId { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<NutiFoodPrefernceDet> NutiFoodPrefernceDets { get; set; }
    }
}
