using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwResidAbsenceStudent
    {
        public int StudentCount { get; set; }
        public DateTime Date { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int? Absence { get; set; }
    }
}
