using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalMedicationName
    {
        public MedicalMedicationName()
        {
            MedicalHospitalVisitDetails = new HashSet<MedicalHospitalVisitDetail>();
            MedicalMedicationStudentDetails = new HashSet<MedicalMedicationStudentDetail>();
        }

        public int MedicationId { get; set; }
        public string MedicationName { get; set; }

        public virtual ICollection<MedicalHospitalVisitDetail> MedicalHospitalVisitDetails { get; set; }
        public virtual ICollection<MedicalMedicationStudentDetail> MedicalMedicationStudentDetails { get; set; }
    }
}
