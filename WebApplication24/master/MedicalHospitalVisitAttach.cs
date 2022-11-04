using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalHospitalVisitAttach
    {
        public int VisitAttachmentId { get; set; }
        public int VisitHospitalId { get; set; }
        public string InvestigationName { get; set; }
        public string Path { get; set; }
        public string Notes { get; set; }

        public virtual MedicalHospitalVisit VisitHospital { get; set; }
    }
}
