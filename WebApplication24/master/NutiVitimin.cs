using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiVitimin
    {
        public NutiVitimin()
        {
            NutiAssesmentVitimins = new HashSet<NutiAssesmentVitimin>();
        }

        public int VitimId { get; set; }
        public string VitimName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<NutiAssesmentVitimin> NutiAssesmentVitimins { get; set; }
    }
}
