using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwPronRptPronAssessmentMove
    {
        public string CategoryName { get; set; }
        public int MoveCategoryId { get; set; }
        public string Movement { get; set; }
        public int MovementId { get; set; }
        public int AssessmentMoveId { get; set; }
        public int AssessmentId { get; set; }
        public string Result { get; set; }
    }
}
