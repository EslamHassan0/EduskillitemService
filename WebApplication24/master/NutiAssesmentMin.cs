using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiAssesmentMin
    {
        public int AssesmentMinId { get; set; }
        public int AssesmentId { get; set; }
        public int MinId { get; set; }

        public virtual NutiAssesment Assesment { get; set; }
        public virtual NutiMin Min { get; set; }
    }
}
