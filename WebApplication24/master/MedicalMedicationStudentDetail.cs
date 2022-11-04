using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalMedicationStudentDetail
    {
        public int MedicationStudDelailId { get; set; }
        public int MedicationStudentId { get; set; }
        public byte MedicationsType { get; set; }
        public int MedicationId { get; set; }
        public string Dose { get; set; }
        public string FreqDay { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual MedicalMedicationName Medication { get; set; }
        public virtual MedicalMedicationStudent MedicationStudent { get; set; }
    }
}
