using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuEvaluationValue
    {
        public int EvaluationValueId { get; set; }
        public string EvaluationName { get; set; }
        public int? Romid { get; set; }

        public virtual NatRom Rom { get; set; }
    }
}
