using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalMedicationStudent
    {
        public MedicalMedicationStudent()
        {
            MedicalMedicationStudentDetails = new HashSet<MedicalMedicationStudentDetail>();
        }

        public int MedicationStudentId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public int? VisitHospitalId { get; set; }
        public int? AssessmentId { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<MedicalMedicationStudentDetail> MedicalMedicationStudentDetails { get; set; }
    }
}
