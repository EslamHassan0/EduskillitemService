using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class Student
    {
        public Student()
        {
            EduEvalutionStudents = new HashSet<EduEvalutionStudent>();
            EduPlanStudies = new HashSet<EduPlanStudy>();
            NatAssesments = new HashSet<NatAssesment>();
            NatProgStudents = new HashSet<NatProgStudent>();
            PsyBehaviorForms = new HashSet<PsyBehaviorForm>();
            PsyCaseStudies = new HashSet<PsyCaseStudy>();
            PsyProblemStudents = new HashSet<PsyProblemStudent>();
        }

        public int StudentId { get; set; }
        public byte SessionId { get; set; }
        public int Serial { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public bool SexType { get; set; }
        public DateTime Birthday { get; set; }
        public int? NationalityId { get; set; }
        public string PhotoPath { get; set; }
        public DateTime DateRegister { get; set; }
        public string SerialPrev { get; set; }
        public int? FileNo { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string Idnumber { get; set; }
        public DateTime? IdnumberExpiryDate { get; set; }
        public string IdspecialCase { get; set; }
        public string NoCivilRegistry { get; set; }
        public string Complaint { get; set; }
        public string MedicalDiagnosis { get; set; }
        public string Diagnosis { get; set; }
        public string DiagnosisDescription { get; set; }
        public string TransferDestination { get; set; }
        public bool? IsResident { get; set; }
        public int? ResidentDepId { get; set; }
        public int? ClassId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<EduEvalutionStudent> EduEvalutionStudents { get; set; }
        public virtual ICollection<EduPlanStudy> EduPlanStudies { get; set; }
        public virtual ICollection<NatAssesment> NatAssesments { get; set; }
        public virtual ICollection<NatProgStudent> NatProgStudents { get; set; }
        public virtual ICollection<PsyBehaviorForm> PsyBehaviorForms { get; set; }
        public virtual ICollection<PsyCaseStudy> PsyCaseStudies { get; set; }
        public virtual ICollection<PsyProblemStudent> PsyProblemStudents { get; set; }
    }
}
