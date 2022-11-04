using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class Student
    {
        public Student()
        {
            DistribTeacherStudentClasses = new HashSet<DistribTeacherStudentClass>();
            EduEvalutionStudents = new HashSet<EduEvalutionStudent>();
            EduPlanStudies = new HashSet<EduPlanStudy>();
            MedicalAssessments = new HashSet<MedicalAssessment>();
            MedicalHospitalVisits = new HashSet<MedicalHospitalVisit>();
            MedicalNurseNotes = new HashSet<MedicalNurseNote>();
            NatAssesments = new HashSet<NatAssesment>();
            NatProgStudents = new HashSet<NatProgStudent>();
            NatRomitems = new HashSet<NatRomitem>();
            NatStudentReports = new HashSet<NatStudentReport>();
            NutiAssesments = new HashSet<NutiAssesment>();
            NutiBcastudents = new HashSet<NutiBcastudent>();
            NutiFoodPrefernces = new HashSet<NutiFoodPrefernce>();
            NutiMealTimeTables = new HashSet<NutiMealTimeTable>();
            NutiOrientations = new HashSet<NutiOrientation>();
            NutiPlanStudents = new HashSet<NutiPlanStudent>();
            OccuAssessments = new HashSet<OccuAssessment>();
            OccuPlans = new HashSet<OccuPlan>();
            OccuReportStudents = new HashSet<OccuReportStudent>();
            PronAssessments = new HashSet<PronAssessment>();
            PronReportStudents = new HashSet<PronReportStudent>();
            PsyBehaviorForms = new HashSet<PsyBehaviorForm>();
            PsyCaseStudies = new HashSet<PsyCaseStudy>();
            PsyProblemStudents = new HashSet<PsyProblemStudent>();
            ResidAbsenceStudents = new HashSet<ResidAbsenceStudent>();
            ResidFinalReports = new HashSet<ResidFinalReport>();
            ResidNoteComunities = new HashSet<ResidNoteComunity>();
            ResidNoteDailyStudents = new HashSet<ResidNoteDailyStudent>();
            ResidOutPermssions = new HashSet<ResidOutPermssion>();
            ResidPersonalAttaches = new HashSet<ResidPersonalAttach>();
            ResidStudRooms = new HashSet<ResidStudRoom>();
            SportPlans = new HashSet<SportPlan>();
            WsEvalutionStudents = new HashSet<WsEvalutionStudent>();
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

        public virtual ICollection<DistribTeacherStudentClass> DistribTeacherStudentClasses { get; set; }
        public virtual ICollection<EduEvalutionStudent> EduEvalutionStudents { get; set; }
        public virtual ICollection<EduPlanStudy> EduPlanStudies { get; set; }
        public virtual ICollection<MedicalAssessment> MedicalAssessments { get; set; }
        public virtual ICollection<MedicalHospitalVisit> MedicalHospitalVisits { get; set; }
        public virtual ICollection<MedicalNurseNote> MedicalNurseNotes { get; set; }
        public virtual ICollection<NatAssesment> NatAssesments { get; set; }
        public virtual ICollection<NatProgStudent> NatProgStudents { get; set; }
        public virtual ICollection<NatRomitem> NatRomitems { get; set; }
        public virtual ICollection<NatStudentReport> NatStudentReports { get; set; }
        public virtual ICollection<NutiAssesment> NutiAssesments { get; set; }
        public virtual ICollection<NutiBcastudent> NutiBcastudents { get; set; }
        public virtual ICollection<NutiFoodPrefernce> NutiFoodPrefernces { get; set; }
        public virtual ICollection<NutiMealTimeTable> NutiMealTimeTables { get; set; }
        public virtual ICollection<NutiOrientation> NutiOrientations { get; set; }
        public virtual ICollection<NutiPlanStudent> NutiPlanStudents { get; set; }
        public virtual ICollection<OccuAssessment> OccuAssessments { get; set; }
        public virtual ICollection<OccuPlan> OccuPlans { get; set; }
        public virtual ICollection<OccuReportStudent> OccuReportStudents { get; set; }
        public virtual ICollection<PronAssessment> PronAssessments { get; set; }
        public virtual ICollection<PronReportStudent> PronReportStudents { get; set; }
        public virtual ICollection<PsyBehaviorForm> PsyBehaviorForms { get; set; }
        public virtual ICollection<PsyCaseStudy> PsyCaseStudies { get; set; }
        public virtual ICollection<PsyProblemStudent> PsyProblemStudents { get; set; }
        public virtual ICollection<ResidAbsenceStudent> ResidAbsenceStudents { get; set; }
        public virtual ICollection<ResidFinalReport> ResidFinalReports { get; set; }
        public virtual ICollection<ResidNoteComunity> ResidNoteComunities { get; set; }
        public virtual ICollection<ResidNoteDailyStudent> ResidNoteDailyStudents { get; set; }
        public virtual ICollection<ResidOutPermssion> ResidOutPermssions { get; set; }
        public virtual ICollection<ResidPersonalAttach> ResidPersonalAttaches { get; set; }
        public virtual ICollection<ResidStudRoom> ResidStudRooms { get; set; }
        public virtual ICollection<SportPlan> SportPlans { get; set; }
        public virtual ICollection<WsEvalutionStudent> WsEvalutionStudents { get; set; }
    }
}
