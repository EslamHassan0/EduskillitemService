using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalHospitalVisit
    {
        public MedicalHospitalVisit()
        {
            MedicalHospitalVisitAttaches = new HashSet<MedicalHospitalVisitAttach>();
            MedicalHospitalVisitDetails = new HashSet<MedicalHospitalVisitDetail>();
        }

        public int VisitHospitalId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string VisitType { get; set; }
        public int HospitalId { get; set; }
        public string ClinicDepartment { get; set; }
        public string DoctorName { get; set; }
        public string Investigations { get; set; }
        public string PlanManagement { get; set; }
        public string Diagnosis { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual MedicalHospital Hospital { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<MedicalHospitalVisitAttach> MedicalHospitalVisitAttaches { get; set; }
        public virtual ICollection<MedicalHospitalVisitDetail> MedicalHospitalVisitDetails { get; set; }
    }
}
