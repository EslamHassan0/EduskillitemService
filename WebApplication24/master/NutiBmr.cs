using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiBmr
    {
        public NutiBmr()
        {
            NutiBcastudents = new HashSet<NutiBcastudent>();
        }

        public int Bmrid { get; set; }
        public string Mbrname { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<NutiBcastudent> NutiBcastudents { get; set; }
    }
}
