using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiFoodIntolerance
    {
        public NutiFoodIntolerance()
        {
            NutiFoodIntoleranceDets = new HashSet<NutiFoodIntoleranceDet>();
        }

        public int FodIntoleranceId { get; set; }
        public int StudentId { get; set; }
        public string Attachment { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int SessionId { get; set; }

        public virtual ICollection<NutiFoodIntoleranceDet> NutiFoodIntoleranceDets { get; set; }
    }
}
