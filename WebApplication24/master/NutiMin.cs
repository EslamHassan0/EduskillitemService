using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiMin
    {
        public NutiMin()
        {
            NutiAssesmentMins = new HashSet<NutiAssesmentMin>();
        }

        public int MinId { get; set; }
        public string MinName { get; set; }
        public byte Action { get; set; }
        public int Createby { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<NutiAssesmentMin> NutiAssesmentMins { get; set; }
    }
}
