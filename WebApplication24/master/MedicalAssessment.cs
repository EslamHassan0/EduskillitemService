using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalAssessment
    {
        public MedicalAssessment()
        {
            MedicalHistories = new HashSet<MedicalHistory>();
            MedicalNurseAssessments = new HashSet<MedicalNurseAssessment>();
            MedicalPhycicanAssessments = new HashSet<MedicalPhycicanAssessment>();
        }

        public int AssessmentId { get; set; }
        public int StudentId { get; set; }
        public int? Serial { get; set; }
        public DateTime? Date { get; set; }
        public byte? Action { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Session { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<MedicalHistory> MedicalHistories { get; set; }
        public virtual ICollection<MedicalNurseAssessment> MedicalNurseAssessments { get; set; }
        public virtual ICollection<MedicalPhycicanAssessment> MedicalPhycicanAssessments { get; set; }
    }
}
