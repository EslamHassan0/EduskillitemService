using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiAssesmentVitimin
    {
        public int AssesmentVitId { get; set; }
        public int AssesmentId { get; set; }
        public int VitimId { get; set; }
        public byte Action { get; set; }
        public int Createby { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual NutiAssesment Assesment { get; set; }
        public virtual NutiVitimin Vitim { get; set; }
    }
}
