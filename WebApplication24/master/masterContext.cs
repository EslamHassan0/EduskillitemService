using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication24.Model
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClClinic> ClClinics { get; set; }
        public virtual DbSet<ClClinicsDoctor> ClClinicsDoctors { get; set; }
        public virtual DbSet<ClService> ClServices { get; set; }
        public virtual DbSet<ClassSchedule> ClassSchedules { get; set; }
        public virtual DbSet<Clinet> Clinets { get; set; }
        public virtual DbSet<DelStudent> DelStudents { get; set; }
        public virtual DbSet<DistribTeacherStudentClass> DistribTeacherStudentClasses { get; set; }
        public virtual DbSet<EduAnalysisItem> EduAnalysisItems { get; set; }
        public virtual DbSet<EduEvalutionDegree> EduEvalutionDegrees { get; set; }
        public virtual DbSet<EduEvalutionStudent> EduEvalutionStudents { get; set; }
        public virtual DbSet<EduEvalutionStudentSkill> EduEvalutionStudentSkills { get; set; }
        public virtual DbSet<EduField> EduFields { get; set; }
        public virtual DbSet<EduFieldSkill> EduFieldSkills { get; set; }
        public virtual DbSet<EduFieldSkillItem> EduFieldSkillItems { get; set; }
        public virtual DbSet<EduPlanLongTarget> EduPlanLongTargets { get; set; }
        public virtual DbSet<EduPlanStudy> EduPlanStudies { get; set; }
        public virtual DbSet<EduPlanStudyReport> EduPlanStudyReports { get; set; }
        public virtual DbSet<EduPlanUseLibrary> EduPlanUseLibraries { get; set; }
        public virtual DbSet<EduResponseValue> EduResponseValues { get; set; }
        public virtual DbSet<EduShortTarget> EduShortTargets { get; set; }
        public virtual DbSet<EduShortTargetAnalysis> EduShortTargetAnalyses { get; set; }
        public virtual DbSet<EduShortTargetAnalysisResponse> EduShortTargetAnalysisResponses { get; set; }
        public virtual DbSet<EduShortTargetEncourage> EduShortTargetEncourages { get; set; }
        public virtual DbSet<EduShortTargetStudyMethod> EduShortTargetStudyMethods { get; set; }
        public virtual DbSet<EduShortTargetTeachingAid> EduShortTargetTeachingAids { get; set; }
        public virtual DbSet<EduStudyMethod> EduStudyMethods { get; set; }
        public virtual DbSet<EduSubject> EduSubjects { get; set; }
        public virtual DbSet<EduTeachingAid> EduTeachingAids { get; set; }
        public virtual DbSet<EndTimePlan> EndTimePlans { get; set; }
        public virtual DbSet<HrDepartment> HrDepartments { get; set; }
        public virtual DbSet<HrEmployee> HrEmployees { get; set; }
        public virtual DbSet<HrEmployee1> HrEmployees1 { get; set; }
        public virtual DbSet<HrJob> HrJobs { get; set; }
        public virtual DbSet<LogStudyPlan> LogStudyPlans { get; set; }
        public virtual DbSet<MedicalAssessment> MedicalAssessments { get; set; }
        public virtual DbSet<MedicalAssessment1> MedicalAssessments1 { get; set; }
        public virtual DbSet<MedicalFormAttach> MedicalFormAttaches { get; set; }
        public virtual DbSet<MedicalHistory> MedicalHistories { get; set; }
        public virtual DbSet<MedicalHospital> MedicalHospitals { get; set; }
        public virtual DbSet<MedicalHospitalVisit> MedicalHospitalVisits { get; set; }
        public virtual DbSet<MedicalHospitalVisitAttach> MedicalHospitalVisitAttaches { get; set; }
        public virtual DbSet<MedicalHospitalVisitDetail> MedicalHospitalVisitDetails { get; set; }
        public virtual DbSet<MedicalInstruction> MedicalInstructions { get; set; }
        public virtual DbSet<MedicalMedicationName> MedicalMedicationNames { get; set; }
        public virtual DbSet<MedicalMedicationStudent> MedicalMedicationStudents { get; set; }
        public virtual DbSet<MedicalMedicationStudentDetail> MedicalMedicationStudentDetails { get; set; }
        public virtual DbSet<MedicalMedicineName> MedicalMedicineNames { get; set; }
        public virtual DbSet<MedicalNurseAssessment> MedicalNurseAssessments { get; set; }
        public virtual DbSet<MedicalNurseNote> MedicalNurseNotes { get; set; }
        public virtual DbSet<MedicalPhycicanAssessment> MedicalPhycicanAssessments { get; set; }
        public virtual DbSet<NatAssesment> NatAssesments { get; set; }
        public virtual DbSet<NatAssesmentItem> NatAssesmentItems { get; set; }
        public virtual DbSet<NatAssesmentRom> NatAssesmentRoms { get; set; }
        public virtual DbSet<NatItem> NatItems { get; set; }
        public virtual DbSet<NatItemGroup> NatItemGroups { get; set; }
        public virtual DbSet<NatItemValue> NatItemValues { get; set; }
        public virtual DbSet<NatItemValueGrp> NatItemValueGrps { get; set; }
        public virtual DbSet<NatProgStudent> NatProgStudents { get; set; }
        public virtual DbSet<NatProgStudentDetail> NatProgStudentDetails { get; set; }
        public virtual DbSet<NatProgram> NatPrograms { get; set; }
        public virtual DbSet<NatRom> NatRoms { get; set; }
        public virtual DbSet<NatRomitem> NatRomitems { get; set; }
        public virtual DbSet<NatStudentReport> NatStudentReports { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Notifcation> Notifcations { get; set; }
        public virtual DbSet<NutiActivityLevel> NutiActivityLevels { get; set; }
        public virtual DbSet<NutiAssesment> NutiAssesments { get; set; }
        public virtual DbSet<NutiAssesmentMin> NutiAssesmentMins { get; set; }
        public virtual DbSet<NutiAssesmentVitimin> NutiAssesmentVitimins { get; set; }
        public virtual DbSet<NutiAssessmentStudent> NutiAssessmentStudents { get; set; }
        public virtual DbSet<NutiBaseIngredient> NutiBaseIngredients { get; set; }
        public virtual DbSet<NutiBcastudent> NutiBcastudents { get; set; }
        public virtual DbSet<NutiBmr> NutiBmrs { get; set; }
        public virtual DbSet<NutiDientPlan> NutiDientPlans { get; set; }
        public virtual DbSet<NutiDiet> NutiDiets { get; set; }
        public virtual DbSet<NutiDietPlanDet> NutiDietPlanDets { get; set; }
        public virtual DbSet<NutiFood> NutiFoods { get; set; }
        public virtual DbSet<NutiFoodGroup> NutiFoodGroups { get; set; }
        public virtual DbSet<NutiFoodIngredient> NutiFoodIngredients { get; set; }
        public virtual DbSet<NutiFoodIntolerance> NutiFoodIntolerances { get; set; }
        public virtual DbSet<NutiFoodIntoleranceDet> NutiFoodIntoleranceDets { get; set; }
        public virtual DbSet<NutiFoodMealType> NutiFoodMealTypes { get; set; }
        public virtual DbSet<NutiFoodPrefernce> NutiFoodPrefernces { get; set; }
        public virtual DbSet<NutiFoodPrefernceDet> NutiFoodPrefernceDets { get; set; }
        public virtual DbSet<NutiFoodUnite> NutiFoodUnites { get; set; }
        public virtual DbSet<NutiMealTime> NutiMealTimes { get; set; }
        public virtual DbSet<NutiMealTimeFood> NutiMealTimeFoods { get; set; }
        public virtual DbSet<NutiMealTimeTable> NutiMealTimeTables { get; set; }
        public virtual DbSet<NutiMealType> NutiMealTypes { get; set; }
        public virtual DbSet<NutiMin> NutiMins { get; set; }
        public virtual DbSet<NutiOrientation> NutiOrientations { get; set; }
        public virtual DbSet<NutiPhysicalActivity> NutiPhysicalActivities { get; set; }
        public virtual DbSet<NutiPlanStudent> NutiPlanStudents { get; set; }
        public virtual DbSet<NutiTexturesfood> NutiTexturesfoods { get; set; }
        public virtual DbSet<NutiVitimin> NutiVitimins { get; set; }
        public virtual DbSet<OccuAssessment> OccuAssessments { get; set; }
        public virtual DbSet<OccuAssessment1> OccuAssessments1 { get; set; }
        public virtual DbSet<OccuAssessmentFirstEva> OccuAssessmentFirstEvas { get; set; }
        public virtual DbSet<OccuAssessmentRom> OccuAssessmentRoms { get; set; }
        public virtual DbSet<OccuEvaluationValue> OccuEvaluationValues { get; set; }
        public virtual DbSet<OccuLongShortTarg> OccuLongShortTargs { get; set; }
        public virtual DbSet<OccuLongTargCurStatu> OccuLongTargCurStatus { get; set; }
        public virtual DbSet<OccuLongTargRecomend> OccuLongTargRecomends { get; set; }
        public virtual DbSet<OccuMethod> OccuMethods { get; set; }
        public virtual DbSet<OccuPlan> OccuPlans { get; set; }
        public virtual DbSet<OccuPlanLongTarget> OccuPlanLongTargets { get; set; }
        public virtual DbSet<OccuReportStudent> OccuReportStudents { get; set; }
        public virtual DbSet<OccuShortTarget> OccuShortTargets { get; set; }
        public virtual DbSet<OccuTool> OccuTools { get; set; }
        public virtual DbSet<PronAchievement> PronAchievements { get; set; }
        public virtual DbSet<PronAssessment> PronAssessments { get; set; }
        public virtual DbSet<PronAssessmentInstruction> PronAssessmentInstructions { get; set; }
        public virtual DbSet<PronAssessmentMove> PronAssessmentMoves { get; set; }
        public virtual DbSet<PronAssessmentOrofacialExam> PronAssessmentOrofacialExams { get; set; }
        public virtual DbSet<PronAssessmentSoundLetter> PronAssessmentSoundLetters { get; set; }
        public virtual DbSet<PronAssessmnetVocab> PronAssessmnetVocabs { get; set; }
        public virtual DbSet<PronInstruction> PronInstructions { get; set; }
        public virtual DbSet<PronLongTarget> PronLongTargets { get; set; }
        public virtual DbSet<PronMedicalCase> PronMedicalCases { get; set; }
        public virtual DbSet<PronMoveCategory> PronMoveCategories { get; set; }
        public virtual DbSet<PronMovement> PronMovements { get; set; }
        public virtual DbSet<PronPlan> PronPlans { get; set; }
        public virtual DbSet<PronPlanTarget> PronPlanTargets { get; set; }
        public virtual DbSet<PronReportStudent> PronReportStudents { get; set; }
        public virtual DbSet<PronSocailHistoryCase> PronSocailHistoryCases { get; set; }
        public virtual DbSet<PronSoundLetter> PronSoundLetters { get; set; }
        public virtual DbSet<PronTargetGoal> PronTargetGoals { get; set; }
        public virtual DbSet<PronTherapeuticGoal> PronTherapeuticGoals { get; set; }
        public virtual DbSet<PronVocab> PronVocabs { get; set; }
        public virtual DbSet<PronVocabCategory> PronVocabCategories { get; set; }
        public virtual DbSet<PsyBehavAnalysisItem> PsyBehavAnalysisItems { get; set; }
        public virtual DbSet<PsyBehaviorForm> PsyBehaviorForms { get; set; }
        public virtual DbSet<PsyBehaviorFormMonitor> PsyBehaviorFormMonitors { get; set; }
        public virtual DbSet<PsyCaseStudy> PsyCaseStudies { get; set; }
        public virtual DbSet<PsyEncourageType> PsyEncourageTypes { get; set; }
        public virtual DbSet<PsyPlanModiBehavMonitor> PsyPlanModiBehavMonitors { get; set; }
        public virtual DbSet<PsyPlanModifiBehavMethEncrage> PsyPlanModifiBehavMethEncrages { get; set; }
        public virtual DbSet<PsyPlanModifiBehavMethod> PsyPlanModifiBehavMethods { get; set; }
        public virtual DbSet<PsyPlanModifiBehavior> PsyPlanModifiBehaviors { get; set; }
        public virtual DbSet<PsyProblem> PsyProblems { get; set; }
        public virtual DbSet<PsyProblemGroup> PsyProblemGroups { get; set; }
        public virtual DbSet<PsyProblemStudent> PsyProblemStudents { get; set; }
        public virtual DbSet<PsyProblemStudent1> PsyProblemStudents1 { get; set; }
        public virtual DbSet<PsyProblemStudentResponse> PsyProblemStudentResponses { get; set; }
        public virtual DbSet<PsyQuestion> PsyQuestions { get; set; }
        public virtual DbSet<ResidAbsenceStudent> ResidAbsenceStudents { get; set; }
        public virtual DbSet<ResidAsset> ResidAssets { get; set; }
        public virtual DbSet<ResidAssetRom> ResidAssetRoms { get; set; }
        public virtual DbSet<ResidComunType> ResidComunTypes { get; set; }
        public virtual DbSet<ResidFinalReport> ResidFinalReports { get; set; }
        public virtual DbSet<ResidNoteCaregiver> ResidNoteCaregivers { get; set; }
        public virtual DbSet<ResidNoteComunity> ResidNoteComunities { get; set; }
        public virtual DbSet<ResidNoteDaily> ResidNoteDailies { get; set; }
        public virtual DbSet<ResidNoteDailyStudent> ResidNoteDailyStudents { get; set; }
        public virtual DbSet<ResidNoteRom> ResidNoteRoms { get; set; }
        public virtual DbSet<ResidNoteType> ResidNoteTypes { get; set; }
        public virtual DbSet<ResidOutPermssion> ResidOutPermssions { get; set; }
        public virtual DbSet<ResidOutPermssionAttach> ResidOutPermssionAttaches { get; set; }
        public virtual DbSet<ResidPersonalAttach> ResidPersonalAttaches { get; set; }
        public virtual DbSet<ResidRepAssociatBehav> ResidRepAssociatBehavs { get; set; }
        public virtual DbSet<ResidRepBehavPattern> ResidRepBehavPatterns { get; set; }
        public virtual DbSet<ResidRepContParent> ResidRepContParents { get; set; }
        public virtual DbSet<ResidRepExcelenActivity> ResidRepExcelenActivities { get; set; }
        public virtual DbSet<ResidRepFavActivity> ResidRepFavActivities { get; set; }
        public virtual DbSet<ResidRepRecomendSuper> ResidRepRecomendSupers { get; set; }
        public virtual DbSet<ResidReportAssociBehav> ResidReportAssociBehavs { get; set; }
        public virtual DbSet<ResidReportBehavPattern> ResidReportBehavPatterns { get; set; }
        public virtual DbSet<ResidReportContParent> ResidReportContParents { get; set; }
        public virtual DbSet<ResidReportExcelenActiv> ResidReportExcelenActivs { get; set; }
        public virtual DbSet<ResidReportFavActivity> ResidReportFavActivities { get; set; }
        public virtual DbSet<ResidReportRecomSuper> ResidReportRecomSupers { get; set; }
        public virtual DbSet<ResidRoom> ResidRooms { get; set; }
        public virtual DbSet<ResidSection> ResidSections { get; set; }
        public virtual DbSet<ResidStudRoom> ResidStudRooms { get; set; }
        public virtual DbSet<ResidTask> ResidTasks { get; set; }
        public virtual DbSet<ResidTaskDate> ResidTaskDates { get; set; }
        public virtual DbSet<ResidTaskSchedule> ResidTaskSchedules { get; set; }
        public virtual DbSet<ResidTaskType> ResidTaskTypes { get; set; }
        public virtual DbSet<ResidTaskschedDetail> ResidTaskschedDetails { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<SportAchievement> SportAchievements { get; set; }
        public virtual DbSet<SportField> SportFields { get; set; }
        public virtual DbSet<SportLongTarget> SportLongTargets { get; set; }
        public virtual DbSet<SportPlan> SportPlans { get; set; }
        public virtual DbSet<SportReportStudent> SportReportStudents { get; set; }
        public virtual DbSet<SportShortTarget> SportShortTargets { get; set; }
        public virtual DbSet<SportShortTargetPlan> SportShortTargetPlans { get; set; }
        public virtual DbSet<SportTargetAchievement> SportTargetAchievements { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Support> Supports { get; set; }
        public virtual DbSet<TableClass> TableClasses { get; set; }
        public virtual DbSet<TableDet> TableDets { get; set; }
        public virtual DbSet<TempNatAssesment> TempNatAssesments { get; set; }
        public virtual DbSet<TempNutiAssesment> TempNutiAssesments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User1> Users1 { get; set; }
        public virtual DbSet<VwEduRptPlanStudent> VwEduRptPlanStudents { get; set; }
        public virtual DbSet<VwEduRptResponsePlanStudent> VwEduRptResponsePlanStudents { get; set; }
        public virtual DbSet<VwNatRptAssessmentItem> VwNatRptAssessmentItems { get; set; }
        public virtual DbSet<VwNatRptAssessmentRom> VwNatRptAssessmentRoms { get; set; }
        public virtual DbSet<VwNatRptProgramStudent> VwNatRptProgramStudents { get; set; }
        public virtual DbSet<VwNatRptReportStudent> VwNatRptReportStudents { get; set; }
        public virtual DbSet<VwNatTbNatRom> VwNatTbNatRoms { get; set; }
        public virtual DbSet<VwNutiAssessmentStudent> VwNutiAssessmentStudents { get; set; }
        public virtual DbSet<VwNutiRptBcastudent> VwNutiRptBcastudents { get; set; }
        public virtual DbSet<VwNutiRptCardStudent> VwNutiRptCardStudents { get; set; }
        public virtual DbSet<VwOccRptAssessment> VwOccRptAssessments { get; set; }
        public virtual DbSet<VwOccuRptPlanTargFinalReport> VwOccuRptPlanTargFinalReports { get; set; }
        public virtual DbSet<VwPronAssessmentInstruction> VwPronAssessmentInstructions { get; set; }
        public virtual DbSet<VwPronAssessmentSoundLetter> VwPronAssessmentSoundLetters { get; set; }
        public virtual DbSet<VwPronRptAssessment> VwPronRptAssessments { get; set; }
        public virtual DbSet<VwPronRptAssessmentInstruction> VwPronRptAssessmentInstructions { get; set; }
        public virtual DbSet<VwPronRptPlan> VwPronRptPlans { get; set; }
        public virtual DbSet<VwPronRptPronAssessmentMove> VwPronRptPronAssessmentMoves { get; set; }
        public virtual DbSet<VwPronRptPronAssessmnetVocab> VwPronRptPronAssessmnetVocabs { get; set; }
        public virtual DbSet<VwPronTbPronAssessment> VwPronTbPronAssessments { get; set; }
        public virtual DbSet<VwResidAbsenceStudent> VwResidAbsenceStudents { get; set; }
        public virtual DbSet<VwResidRptOutPermssion> VwResidRptOutPermssions { get; set; }
        public virtual DbSet<VwResidRptTaskSchedule> VwResidRptTaskSchedules { get; set; }
        public virtual DbSet<VwRptEduEvalutionStudent> VwRptEduEvalutionStudents { get; set; }
        public virtual DbSet<VwRptPsyBehaviorForm> VwRptPsyBehaviorForms { get; set; }
        public virtual DbSet<VwRptPsyCaseStudy> VwRptPsyCaseStudies { get; set; }
        public virtual DbSet<VwRptPsyPlanModified> VwRptPsyPlanModifieds { get; set; }
        public virtual DbSet<VwSportPlan> VwSportPlans { get; set; }
        public virtual DbSet<VwSportRptEvalution> VwSportRptEvalutions { get; set; }
        public virtual DbSet<VwSportRptPlan> VwSportRptPlans { get; set; }
        public virtual DbSet<VwTbNatItemValue> VwTbNatItemValues { get; set; }
        public virtual DbSet<WorkShopTeacher> WorkShopTeachers { get; set; }
        public virtual DbSet<WorkShopType> WorkShopTypes { get; set; }
        public virtual DbSet<WsEvalutionStudent> WsEvalutionStudents { get; set; }
        public virtual DbSet<WsEvalutionStudentSkill> WsEvalutionStudentSkills { get; set; }
        public virtual DbSet<WsSkilI> WsSkilIs { get; set; }
        public virtual DbSet<YearStudy> YearStudies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TF0HS6G;Database=master;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ClClinic>(entity =>
            {
                entity.HasKey(e => e.ClinicId);

                entity.ToTable("clClinics");

                entity.HasComment("العيادات");

                entity.Property(e => e.ClinicId).HasColumnName("ClinicID");

                entity.Property(e => e.ClinicName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("اسم العيادة");

                entity.Property(e => e.DiagnosisPeriod).HasComment("مدة الكشف بالدقيقة");
            });

            modelBuilder.Entity<ClClinicsDoctor>(entity =>
            {
                entity.HasKey(e => e.ClinicDoctorId);

                entity.ToTable("clClinicsDoctor");

                entity.Property(e => e.ClinicDoctorId).HasColumnName("ClinicDoctorID");

                entity.Property(e => e.ClinicId).HasColumnName("ClinicID");

                entity.Property(e => e.DelayFeesComp)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("بياخد اجر عيادات الشركات متاخر فى الشهر اللى بعده\r\n1- نعم بياخدها متاخر\r\n0- لا بياخجها فى نفس الشهر");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsUseMiniCharge)
                    .HasColumnName("IS_UseMiniCharge")
                    .HasComment("فى حالة الاطباء لهم حد ادنى لليوم فى حالة عدم تحقيق العياده فى هذا اليوم");

                entity.Property(e => e.MiniTargetClinicValue).HasComment("اقل قيمة للعياده بعدها ياخد الحد الادنى  للاجر الخاص به");

                entity.Property(e => e.PrecentageHospial).HasColumnName("precentageHospial");

                entity.Property(e => e.ValueDoctor).HasComment("قسمة الاجر المستحق فى حالة عدم تحقيق تارجت العياده");

                entity.HasOne(d => d.Clinic)
                    .WithMany(p => p.ClClinicsDoctors)
                    .HasForeignKey(d => d.ClinicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_clClinicsDoctor_clClinics");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ClClinicsDoctors)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_clClinicsDoctor_hrEmployees");
            });

            modelBuilder.Entity<ClService>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("clServices");

                entity.HasComment("ÇáÎÏãÇÊ ÇáãÎÊáÝÉ ááÚíÇÏÇÊ");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ClinicId)
                    .HasColumnName("ClinicID")
                    .HasComment("ãÓáÓá ÇáÚíÇÏÉ ÇáÊÇÈÚ áåÇ åÐå ÇáÎÏãÉ");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasMaxLength(350)
                    .HasColumnName("description");

                entity.Property(e => e.IsNotShareDoc)
                    .HasColumnName("Is_NotShareDoc")
                    .HasDefaultValueSql("((0))")
                    .HasComment("åÐå ÇáÎÏãÉ áÇ íÔÊÑß ÇáÇØÈÇÁ ÝíåÇ Ýì ÇáÍÓÇÈ");

                entity.Property(e => e.IsService).HasColumnName("Is_service");

                entity.Property(e => e.IsShow).HasColumnName("Is_Show");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasComment("ãÓáÓá ÇáÎÏãÉ ÇáÇÈ áåÐå ÇáÎÏãÉ");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(700)
                    .HasComment("ÇÓã ÇáÎÏãÉ");

                entity.Property(e => e.ServicePrice).HasComment("ÓÚÑ ÇáÎÏãÉ");

                entity.Property(e => e.SpeServiceComp).HasComment("add this fielf for new price company - Êã ÇÖÇÝÉ åÐÐÇ ÇáÝíáÏ áÊãíÒ ÇÓÚÇÑ ÎÏãÇÊ áÔÑßÇÊ ÇÓÚÇÑåÇ åíßæä ãÎÊáÝ Úä ÈÇÞì ÇáÇÓÚÇÑ ÇáãÓÊÎÏãÉ Ýì 2020");
            });

            modelBuilder.Entity<ClassSchedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleId);

                entity.ToTable("ClassSchedule");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.ClassNo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<Clinet>(entity =>
            {
                entity.ToTable("Clinet");

                entity.Property(e => e.ClinetId).HasColumnName("ClinetID");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PostDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<DelStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DelStudent");

                entity.Property(e => e.Birthday)
                    .HasMaxLength(150)
                    .HasColumnName("birthday");

                entity.Property(e => e.Idno)
                    .HasMaxLength(150)
                    .HasColumnName("IDNO");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(250)
                    .HasColumnName("nameAr");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.Passport)
                    .HasMaxLength(250)
                    .HasColumnName("passport");

                entity.Property(e => e.PrevServail).HasMaxLength(150);

                entity.Property(e => e.Resident)
                    .HasMaxLength(50)
                    .HasColumnName("resident");

                entity.Property(e => e.Serial).HasMaxLength(150);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .HasColumnName("sex");

                entity.Property(e => e.StudentN)
                    .HasMaxLength(250)
                    .HasColumnName("studentN");
            });

            modelBuilder.Entity<DistribTeacherStudentClass>(entity =>
            {
                entity.HasKey(e => e.TeacherStudId)
                    .HasName("PK_TeacherStudentClass");

                entity.ToTable("DistribTeacherStudentClass");

                entity.Property(e => e.TeacherStudId).HasColumnName("TeacherStudID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.DistribTeacherStudentClasses)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherStudentClass_Semester");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.DistribTeacherStudentClasses)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherStudentClass_Student");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.DistribTeacherStudentClasses)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherStudentClass_HrEmployee");
            });

            modelBuilder.Entity<EduAnalysisItem>(entity =>
            {
                entity.HasKey(e => e.AnalysisItemId);

                entity.ToTable("EduAnalysisItem");

                entity.Property(e => e.AnalysisItemId)
                    .HasColumnName("AnalysisItemID")
                    .HasComment("مسلسل عناصر التحليل للهدف");

                entity.Property(e => e.AnalysisName)
                    .HasMaxLength(150)
                    .HasComment("مسمسى عنصر التحليل للهدف");
            });

            modelBuilder.Entity<EduEvalutionDegree>(entity =>
            {
                entity.HasKey(e => e.DegreeId);

                entity.ToTable("EduEvalutionDegree");

                entity.Property(e => e.DegreeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DegreeID")
                    .HasComment("مسلسل التقييم");

                entity.Property(e => e.Degree)
                    .HasMaxLength(50)
                    .HasComment("قيمة التقييم");
            });

            modelBuilder.Entity<EduEvalutionStudent>(entity =>
            {
                entity.HasKey(e => e.EvalutionId);

                entity.ToTable("EduEvalutionStudent");

                entity.Property(e => e.EvalutionId)
                    .HasColumnName("EvalutionID")
                    .HasComment("مسلسل التقيم المبدىء للطالب");

                entity.Property(e => e.CreatedBy).HasComment("انشىء بواسطة");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ الانشاء");

                entity.Property(e => e.DateEvalution)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ التقييم المبدىء");

                entity.Property(e => e.Recommendation)
                    .IsRequired()
                    .HasComment("التوصية و الملاحظات");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasComment("مسلسل الطالب");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.EduEvalutionStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduEvalutionStudent_Student");
            });

            modelBuilder.Entity<EduEvalutionStudentSkill>(entity =>
            {
                entity.HasKey(e => e.EvalutionSlilId)
                    .HasName("PK_EduEvalutionStudentField");

                entity.ToTable("EduEvalutionStudentSkill");

                entity.Property(e => e.EvalutionSlilId).HasColumnName("EvalutionSlilID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EvalutionId).HasColumnName("EvalutionID");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.SkillItemId).HasColumnName("SkillItemID");

                entity.HasOne(d => d.Degree)
                    .WithMany(p => p.EduEvalutionStudentSkills)
                    .HasForeignKey(d => d.DegreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduEvalutionStudentSkill_EduEvalutionDegree");

                entity.HasOne(d => d.Evalution)
                    .WithMany(p => p.EduEvalutionStudentSkills)
                    .HasForeignKey(d => d.EvalutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduEvalutionStudentSkill_EduEvalutionStudent");

                entity.HasOne(d => d.SkillItem)
                    .WithMany(p => p.EduEvalutionStudentSkills)
                    .HasForeignKey(d => d.SkillItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduEvalutionStudentSkill_EduFieldSkill");
            });

            modelBuilder.Entity<EduField>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("EduField");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FieldID")
                    .HasComment("مسلسل المجال");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(150)
                    .HasComment("اسم المجال");
            });

            modelBuilder.Entity<EduFieldSkill>(entity =>
            {
                entity.HasKey(e => e.SkillD);

                entity.ToTable("EduFieldSkill");

                entity.Property(e => e.SkillD).HasComment("مسلسل المهارة");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FieldID")
                    .HasComment("مسلسل المجال");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasComment("اسم المهارة");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.EduFieldSkills)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduFieldSkill_EduField");
            });

            modelBuilder.Entity<EduFieldSkillItem>(entity =>
            {
                entity.HasKey(e => e.SkillItemId);

                entity.ToTable("EduFieldSkillItem");

                entity.Property(e => e.SkillItemId).HasColumnName("SkillItemID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.SkillDNavigation)
                    .WithMany(p => p.EduFieldSkillItems)
                    .HasForeignKey(d => d.SkillD)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduFieldSkillItem_EduFieldSkill");
            });

            modelBuilder.Entity<EduPlanLongTarget>(entity =>
            {
                entity.HasKey(e => e.LongTargetId);

                entity.ToTable("EduPlanLongTarget");

                entity.Property(e => e.LongTargetId)
                    .HasColumnName("LongTargetID")
                    .HasComment("مسلسل الهدف طويل المدى");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FieldID")
                    .HasComment("مسلسل المجال");

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("الهدف طويل المدى");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.PlanStudyId)
                    .HasColumnName("PlanStudyID")
                    .HasComment("مسمسل الخطة التربيوية\r\nفى حالة عدم ادخال مسلسل خطة تربية سوف يكون الهدف هنا نموذج للاهداف يمكن تمريره للطلاب بعد ذلك عند اختياره");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.EduPlanLongTargets)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduPlanLongTarget_EduField");

                entity.HasOne(d => d.PlanStudy)
                    .WithMany(p => p.EduPlanLongTargets)
                    .HasForeignKey(d => d.PlanStudyId)
                    .HasConstraintName("FK_EduPlanLongTarget_EduPlanStudy");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.EduPlanLongTargets)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_EduPlanLongTarget_Semester");
            });

            modelBuilder.Entity<EduPlanStudy>(entity =>
            {
                entity.HasKey(e => e.PlanStudyId);

                entity.ToTable("EduPlanStudy");

                entity.Property(e => e.PlanStudyId)
                    .HasColumnName("PlanStudyID")
                    .HasComment("مسلسل الخطة التعليمية ");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ بداية الخطة");

                entity.Property(e => e.DateTo)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ نهاية الخطة");

                entity.Property(e => e.IsApproveSuperVisor)
                    .HasColumnName("IS_ApproveSuperVisor")
                    .HasComment("تم موافقة المشرف على الخطة");

                entity.Property(e => e.PlanName).HasMaxLength(150);

                entity.Property(e => e.RejectReason).HasMaxLength(350);

                entity.Property(e => e.SemesterId)
                    .HasColumnName("SemesterID")
                    .HasComment("مسلسل الفصل الدراسى");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasComment("مسلسل الطالب");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.EduPlanStudies)
                    .HasForeignKey(d => d.CreateBy)
                    .HasConstraintName("FK_EduPlanStudy_User");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.EduPlanStudies)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_EduPlanStudy_Semester");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.EduPlanStudies)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduPlanStudy_Student");
            });

            modelBuilder.Entity<EduPlanStudyReport>(entity =>
            {
                entity.HasKey(e => e.PlanReportId);

                entity.ToTable("EduPlanStudyReport");

                entity.Property(e => e.PlanReportId).HasColumnName("PlanReportID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlanStudyId).HasColumnName("PlanStudyID");

                entity.Property(e => e.Report).IsRequired();

                entity.HasOne(d => d.PlanStudy)
                    .WithMany(p => p.EduPlanStudyReports)
                    .HasForeignKey(d => d.PlanStudyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduPlanStudyReport_EduPlanStudy");
            });

            modelBuilder.Entity<EduPlanUseLibrary>(entity =>
            {
                entity.HasKey(e => e.LibraryId);

                entity.ToTable("EduPlanUseLibrary");

                entity.Property(e => e.LibraryId).HasColumnName("LibraryID");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.LongTargetIdfrmLibrary).HasColumnName("LongTargetIDFrmLibrary");
            });

            modelBuilder.Entity<EduResponseValue>(entity =>
            {
                entity.HasKey(e => e.ResponseValueId);

                entity.ToTable("EduResponseValue");

                entity.Property(e => e.ResponseValueId).HasColumnName("ResponseValueID");

                entity.Property(e => e.ResponseName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<EduShortTarget>(entity =>
            {
                entity.HasKey(e => e.ShortTargetId);

                entity.ToTable("EduShortTarget");

                entity.Property(e => e.ShortTargetId)
                    .HasColumnName("ShortTargetID")
                    .HasComment("مسلسل الهدف قصير المدى");

                entity.Property(e => e.DateApprove).HasColumnType("smalldatetime");

                entity.Property(e => e.IsApprove).HasColumnName("IS_Approve");

                entity.Property(e => e.LongTargetId)
                    .HasColumnName("LongTargetID")
                    .HasComment("مسلسل الهدف طويل المدى");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.ShortTargetName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("مسمى الهدف قصير المدى");

                entity.HasOne(d => d.LongTarget)
                    .WithMany(p => p.EduShortTargets)
                    .HasForeignKey(d => d.LongTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTarget_EduPlanLongTarget");
            });

            modelBuilder.Entity<EduShortTargetAnalysis>(entity =>
            {
                entity.HasKey(e => e.ShortTargetAnalysisId);

                entity.ToTable("EduShortTargetAnalysis");

                entity.Property(e => e.ShortTargetAnalysisId)
                    .HasColumnName("ShortTargetAnalysisID")
                    .HasComment("مسلسل تحليل الهدف قصير المدى");

                entity.Property(e => e.AnalysisItemId)
                    .HasColumnName("AnalysisItemID")
                    .HasComment("مسلسل عنصر تحليل الهدف");

                entity.Property(e => e.ShortTargetId)
                    .HasColumnName("ShortTargetID")
                    .HasComment("مسمسل الهدف قصير المدى");

                entity.HasOne(d => d.AnalysisItem)
                    .WithMany(p => p.EduShortTargetAnalyses)
                    .HasForeignKey(d => d.AnalysisItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetAnalysis_EduAnalysisItem");

                entity.HasOne(d => d.ShortTarget)
                    .WithMany(p => p.EduShortTargetAnalyses)
                    .HasForeignKey(d => d.ShortTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetAnalysis_EduShortTarget");
            });

            modelBuilder.Entity<EduShortTargetAnalysisResponse>(entity =>
            {
                entity.HasKey(e => e.ResponseAnalysisId);

                entity.ToTable("EduShortTargetAnalysisResponse");

                entity.Property(e => e.ResponseAnalysisId).HasColumnName("ResponseAnalysisID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.RepeatNo).HasColumnName("RepeatNO");

                entity.Property(e => e.ResponseValueId).HasColumnName("ResponseValueID");

                entity.Property(e => e.ShortTargetAnalysisId).HasColumnName("ShortTargetAnalysisID");

                entity.HasOne(d => d.ResponseValue)
                    .WithMany(p => p.EduShortTargetAnalysisResponses)
                    .HasForeignKey(d => d.ResponseValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetAnalysisResponse_EduResponseValue");

                entity.HasOne(d => d.ShortTargetAnalysis)
                    .WithMany(p => p.EduShortTargetAnalysisResponses)
                    .HasForeignKey(d => d.ShortTargetAnalysisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetAnalysisResponse_EduShortTargetAnalysis");
            });

            modelBuilder.Entity<EduShortTargetEncourage>(entity =>
            {
                entity.HasKey(e => e.EncourageTargId);

                entity.ToTable("EduShortTargetEncourage");

                entity.Property(e => e.EncourageTargId).HasColumnName("EncourageTargID");

                entity.Property(e => e.EncourageTypeId).HasColumnName("EncourageTypeID");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.ShortTargetId).HasColumnName("ShortTargetID");

                entity.HasOne(d => d.EncourageType)
                    .WithMany(p => p.EduShortTargetEncourages)
                    .HasForeignKey(d => d.EncourageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetEncourage_PsyEncourageType");

                entity.HasOne(d => d.ShortTarget)
                    .WithMany(p => p.EduShortTargetEncourages)
                    .HasForeignKey(d => d.ShortTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetEncourage_EduShortTarget");
            });

            modelBuilder.Entity<EduShortTargetStudyMethod>(entity =>
            {
                entity.HasKey(e => e.ShortTargStudyMethId);

                entity.ToTable("EduShortTargetStudyMethod");

                entity.Property(e => e.ShortTargStudyMethId)
                    .HasColumnName("ShortTargStudyMethID")
                    .HasComment("مسمسل اسليب الدراسة للهدف قصير المدى");

                entity.Property(e => e.ShortTargetId)
                    .HasColumnName("ShortTargetID")
                    .HasComment("مسمسل الهدف قصير المدى");

                entity.Property(e => e.StudyMethodId)
                    .HasColumnName("StudyMethodID")
                    .HasComment("مسلسل اساليب الدراسة");

                entity.HasOne(d => d.ShortTarget)
                    .WithMany(p => p.EduShortTargetStudyMethods)
                    .HasForeignKey(d => d.ShortTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetStudyMethod_EduShortTarget");

                entity.HasOne(d => d.StudyMethod)
                    .WithMany(p => p.EduShortTargetStudyMethods)
                    .HasForeignKey(d => d.StudyMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetStudyMethod_EduStudyMethod");
            });

            modelBuilder.Entity<EduShortTargetTeachingAid>(entity =>
            {
                entity.HasKey(e => e.ShortTargTeachId);

                entity.ToTable("EduShortTargetTeachingAid");

                entity.Property(e => e.ShortTargTeachId)
                    .HasColumnName("ShortTargTeachID")
                    .HasComment("مسمسل وسائل التدريس للهدف قصير المدى");

                entity.Property(e => e.ShortTargetId)
                    .HasColumnName("ShortTargetID")
                    .HasComment("مسلسل الهدف قصير المدى");

                entity.Property(e => e.TeachingAidsId)
                    .HasColumnName("TeachingAidsID")
                    .HasComment("مسلسل وسائل التدريس");

                entity.HasOne(d => d.ShortTarget)
                    .WithMany(p => p.EduShortTargetTeachingAids)
                    .HasForeignKey(d => d.ShortTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetTeachingAid_EduShortTarget");

                entity.HasOne(d => d.TeachingAids)
                    .WithMany(p => p.EduShortTargetTeachingAids)
                    .HasForeignKey(d => d.TeachingAidsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduShortTargetTeachingAid_EduTeachingAid");
            });

            modelBuilder.Entity<EduStudyMethod>(entity =>
            {
                entity.HasKey(e => e.StudyMethodId);

                entity.ToTable("EduStudyMethod");

                entity.Property(e => e.StudyMethodId)
                    .HasColumnName("StudyMethodID")
                    .HasComment("مسلسل اساليت الدراسة");

                entity.Property(e => e.StudyMethodName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("مسمى اساليب الدراسة");
            });

            modelBuilder.Entity<EduSubject>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.ToTable("EduSubject");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EduTeachingAid>(entity =>
            {
                entity.HasKey(e => e.TeachingAidsId);

                entity.ToTable("EduTeachingAid");

                entity.Property(e => e.TeachingAidsId)
                    .HasColumnName("TeachingAidsID")
                    .HasComment("مسلسل وسائل الدريس");

                entity.Property(e => e.TeachingAidsName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("مسمسى وسيلة التدريس");
            });

            modelBuilder.Entity<EndTimePlan>(entity =>
            {
                entity.HasKey(e => e.EndTimeId);

                entity.ToTable("EndTimePlan");

                entity.Property(e => e.EndTimeId).HasColumnName("EndTimeID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.PostDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EndTimePlans)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EndTimePlan_Semester");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.EndTimePlans)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EndTimePlan_Semester1");
            });

            modelBuilder.Entity<HrDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("HrDepartment");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Notes).HasMaxLength(350);
            });

            modelBuilder.Entity<HrEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_Employee");

                entity.ToTable("HrEmployee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NameEnglish).HasMaxLength(250);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.HrEmployees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_HrEmployee_HrDepartment");
            });

            modelBuilder.Entity<HrEmployee1>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("hrEmployees");

                entity.HasComment("جدول بيانات الموظفين - بيانات أساسية");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("رقم مسلسل للجدول");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnType("datetime")
                    .HasComment("تاريخ التعيين");

                entity.Property(e => e.BankAccount).HasMaxLength(200);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("رقم مسلسل الفئة");

                entity.Property(e => e.ContractNo).HasMaxLength(200);

                entity.Property(e => e.ContractType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DepId)
                    .HasColumnName("DepID")
                    .HasComment("رقم مسلسل القسم");

                entity.Property(e => e.DocSalaryType).HasComment("نوع الاجر في حالة الاطباء\r\n===============\r\n1 اجر يومي ثابت\r\n2 اجر شهري ثابت\r\n3 نسبة من الايراد الشهري\r\n4 قيمة ثابتة للحالة\r\n5 متطوع مجاني");

                entity.Property(e => e.DocSalaryValue).HasComment("قيمة اجر الطبيب حسب نوعه\r\n=====================\r\nقيمة يوم الاجر اليومي\r\nقيمة شهر الاجر الشهري\r\nنسبة الايراد\r\nقيمة الحالة");

                entity.Property(e => e.DriveLicenseEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DriveLicenseIssuePlace).HasMaxLength(50);

                entity.Property(e => e.DriveLicenseNo).HasMaxLength(50);

                entity.Property(e => e.DriveLicenseStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DutyPositionType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("الموقف من الخدمة فى الشركة : 1 - داخل الخدمة   &   2 - خارج الخدمة");

                entity.Property(e => e.EmployeeAddress)
                    .HasMaxLength(250)
                    .HasComment("العنوان");

                entity.Property(e => e.EmployeeBirthDate)
                    .HasColumnType("datetime")
                    .HasComment("تاريخ الميلاد");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("كود الموظف - لابد من الإدخال - لا يكرر");

                entity.Property(e => e.EmployeeHireType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("نوع عمل الموظف  \r\n1- FullTime \r\n2- PartTime");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم الموظف - لابد من الإدخال - لا يكرر");

                entity.Property(e => e.EmployeeNotes)
                    .HasMaxLength(200)
                    .HasComment("ملاحظات");

                entity.Property(e => e.EmployeePhoto)
                    .HasMaxLength(100)
                    .HasComment("صورة الموظف");

                entity.Property(e => e.EmployeeSexType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("نوع الجنس : 1 - ذكر   &   2 - أنثى");

                entity.Property(e => e.EmployeeTelephones)
                    .HasMaxLength(150)
                    .HasComment("التليفونات");

                entity.Property(e => e.IdentityCardDate)
                    .HasColumnType("datetime")
                    .HasComment("تاريخ صدور تحقيق الشخصية");

                entity.Property(e => e.IdentityCardNo)
                    .HasMaxLength(50)
                    .HasComment("رقم تحقيق الشخصية");

                entity.Property(e => e.IdentityCardPlace)
                    .HasMaxLength(250)
                    .HasComment("مكان صدور تحقيق الشخصية");

                entity.Property(e => e.IdentityCardTypeId)
                    .HasColumnName("IdentityCardTypeID")
                    .HasComment("رقم مسلسل نوع تحقيق الشخصية");

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.OutDutyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OutDutyReason).HasMaxLength(200);

                entity.Property(e => e.PassportEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PassportIssuePlace).HasMaxLength(50);

                entity.Property(e => e.PassportNo).HasMaxLength(50);

                entity.Property(e => e.PassportStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.ResidenceEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ResidenceIssuePlace).HasMaxLength(50);

                entity.Property(e => e.ResidenceNo).HasMaxLength(50);

                entity.Property(e => e.ResidenceStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SocialSecurityNo).HasMaxLength(50);

                entity.Property(e => e.SocialStatusTypeId)
                    .HasColumnName("SocialStatusTypeID")
                    .HasComment("رقم مسلسل نوع الحالة الإجتماعية");

                entity.Property(e => e.WorkOfficeRegDate).HasColumnType("smalldatetime");

                entity.Property(e => e.WorkOfficeRegistration)
                    .HasMaxLength(50)
                    .HasComment("قيد مكتب العمل");
            });

            modelBuilder.Entity<HrJob>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.ToTable("HrJob");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(250);
            });

            modelBuilder.Entity<LogStudyPlan>(entity =>
            {
                entity.HasKey(e => e.LogStudyId);

                entity.ToTable("LogStudyPlan");

                entity.Property(e => e.LogStudyId).HasColumnName("LogStudyID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.PlanStudyId).HasColumnName("PlanStudyID");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.Property(e => e.TbDesc)
                    .HasMaxLength(150)
                    .HasColumnName("tb_desc");

                entity.Property(e => e.TbName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tbName");
            });

            modelBuilder.Entity<MedicalAssessment>(entity =>
            {
                entity.HasKey(e => e.AssessmentId);

                entity.ToTable("MedicalAssessment");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.MedicalAssessments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalAssessment_Student");
            });

            modelBuilder.Entity<MedicalAssessment1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MedicalAssessments");

                entity.Property(e => e.AbBirthWeight)
                    .HasMaxLength(50)
                    .HasColumnName("AB_BirthWeight");

                entity.Property(e => e.AbGestationalAge)
                    .HasMaxLength(50)
                    .HasColumnName("AB_GestationalAge");

                entity.Property(e => e.AbNotes)
                    .HasMaxLength(50)
                    .HasColumnName("AB_Notes");

                entity.Property(e => e.AbResuscitation)
                    .HasMaxLength(50)
                    .HasColumnName("AB_Resuscitation");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.Bp)
                    .HasMaxLength(50)
                    .HasColumnName("BP");

                entity.Property(e => e.CardiovascularSystem).HasMaxLength(350);

                entity.Property(e => e.ChiefComplaints).HasMaxLength(250);

                entity.Property(e => e.Cns)
                    .HasMaxLength(350)
                    .HasColumnName("CNS");

                entity.Property(e => e.Convulsion).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DiseaseAllergies)
                    .HasMaxLength(150)
                    .HasColumnName("diseaseAllergies");

                entity.Property(e => e.Dm).HasColumnName("DM");

                entity.Property(e => e.DrugHxmaintenance)
                    .HasMaxLength(150)
                    .HasColumnName("Drug_HXMaintenance");

                entity.Property(e => e.DrugPlanManagement)
                    .HasMaxLength(150)
                    .HasColumnName("Drug_planManagement");

                entity.Property(e => e.Ent)
                    .HasMaxLength(350)
                    .HasColumnName("ENT");

                entity.Property(e => e.EventConvulsion)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Convulsion");

                entity.Property(e => e.EventInfections)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Infections");

                entity.Property(e => e.EventMilestone)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Milestone");

                entity.Property(e => e.EventNotes)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Notes");

                entity.Property(e => e.EventOtherChronic)
                    .HasMaxLength(100)
                    .HasColumnName("Event_OtherChronic");

                entity.Property(e => e.EventSurgical)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Surgical");

                entity.Property(e => e.EventSymptoms)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Symptoms");

                entity.Property(e => e.EventTrauma)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Trauma");

                entity.Property(e => e.EventVaccinations)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Vaccinations");

                entity.Property(e => e.EyeOpening).HasMaxLength(50);

                entity.Property(e => e.FhmHxsimilar)
                    .HasMaxLength(250)
                    .HasColumnName("FHM_HXSimilar");

                entity.Property(e => e.FhmOthers)
                    .HasMaxLength(250)
                    .HasColumnName("FHM_Others");

                entity.Property(e => e.FmhCardiac).HasColumnName("FMH_Cardiac");

                entity.Property(e => e.FmhDm).HasColumnName("FMH_DM");

                entity.Property(e => e.FmhHaematological).HasColumnName("FMH_Haematological");

                entity.Property(e => e.FmhHtn).HasColumnName("FMH_HTN");

                entity.Property(e => e.FmhRenal).HasColumnName("FMH_Renal");

                entity.Property(e => e.FmhRespiratory).HasColumnName("FMH_Respiratory");

                entity.Property(e => e.Gd).HasColumnName("GD");

                entity.Property(e => e.GeneralAppearance).HasMaxLength(250);

                entity.Property(e => e.Git)
                    .HasMaxLength(350)
                    .HasColumnName("GIT");

                entity.Property(e => e.GlasgowComaScale).HasMaxLength(50);

                entity.Property(e => e.Height).HasMaxLength(50);

                entity.Property(e => e.Htn).HasColumnName("HTN");

                entity.Property(e => e.Infections).HasMaxLength(150);

                entity.Property(e => e.LearningDifficulties).HasMaxLength(150);

                entity.Property(e => e.MainDiagnosisHistory).HasMaxLength(250);

                entity.Property(e => e.MedicalDiagnosis).HasMaxLength(250);

                entity.Property(e => e.MedicalHistoryId).HasColumnName("MedicalHistoryID");

                entity.Property(e => e.ModeDelivery).HasMaxLength(50);

                entity.Property(e => e.MotorResponse).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.NotesDuringDelivery).HasMaxLength(250);

                entity.Property(e => e.NotesHealthProb).HasMaxLength(250);

                entity.Property(e => e.NurseAssessmnetId).HasColumnName("NurseAssessmnetID");

                entity.Property(e => e.OphthalmicAssess).HasMaxLength(350);

                entity.Property(e => e.OtherChronic).HasMaxLength(250);

                entity.Property(e => e.OtherRespiratory).HasMaxLength(350);

                entity.Property(e => e.Others).HasMaxLength(350);

                entity.Property(e => e.PainScore).HasMaxLength(50);

                entity.Property(e => e.PhycicanAssessmentId).HasColumnName("PhycicanAssessmentID");

                entity.Property(e => e.Pih).HasColumnName("PIH");

                entity.Property(e => e.PresentComplaints).HasMaxLength(250);

                entity.Property(e => e.PsychoTraumeAfter5Fyear)
                    .HasMaxLength(100)
                    .HasColumnName("Psycho_TraumeAfter5Fyear");

                entity.Property(e => e.PsychoTraumeInFyear)
                    .HasMaxLength(100)
                    .HasColumnName("Psycho_TraumeInFyear");

                entity.Property(e => e.PsychologicalHistory).HasMaxLength(150);

                entity.Property(e => e.Pulse).HasMaxLength(50);

                entity.Property(e => e.PulseCharacter).HasMaxLength(50);

                entity.Property(e => e.Recommendations).HasMaxLength(350);

                entity.Property(e => e.Respcharacter)
                    .HasMaxLength(50)
                    .HasColumnName("RESPCharacter");

                entity.Property(e => e.RespiratorySystem).HasMaxLength(350);

                entity.Property(e => e.Rr)
                    .HasMaxLength(50)
                    .HasColumnName("RR");

                entity.Property(e => e.Skin).HasMaxLength(350);

                entity.Property(e => e.SocialHParentsStatus)
                    .HasMaxLength(100)
                    .HasColumnName("SocialH_ParentsStatus");

                entity.Property(e => e.SocialHistory).HasMaxLength(150);

                entity.Property(e => e.Spo2)
                    .HasMaxLength(50)
                    .HasColumnName("SPO2");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.SurgicalOperations).HasMaxLength(150);

                entity.Property(e => e.SymptomsDisability).HasMaxLength(250);

                entity.Property(e => e.Temp).HasMaxLength(50);

                entity.Property(e => e.Trauma).HasMaxLength(150);

                entity.Property(e => e.TypeDelivery).HasMaxLength(50);

                entity.Property(e => e.VerbalResponse).HasMaxLength(50);

                entity.Property(e => e.Weight).HasMaxLength(50);
            });

            modelBuilder.Entity<MedicalFormAttach>(entity =>
            {
                entity.HasKey(e => e.UserGuidId);

                entity.ToTable("MedicalFormAttach");

                entity.Property(e => e.UserGuidId).HasColumnName("UserGuidID");

                entity.Property(e => e.Attachment)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<MedicalHistory>(entity =>
            {
                entity.ToTable("MedicalHistory");

                entity.Property(e => e.MedicalHistoryId).HasColumnName("MedicalHistoryID");

                entity.Property(e => e.AbBirthWeight)
                    .HasMaxLength(50)
                    .HasColumnName("AB_BirthWeight");

                entity.Property(e => e.AbGestationalAge)
                    .HasMaxLength(50)
                    .HasColumnName("AB_GestationalAge");

                entity.Property(e => e.AbNotes)
                    .HasMaxLength(50)
                    .HasColumnName("AB_Notes");

                entity.Property(e => e.AbResuscitation)
                    .HasMaxLength(50)
                    .HasColumnName("AB_Resuscitation");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.Convulsion).HasMaxLength(150);

                entity.Property(e => e.DiseaseAllergies)
                    .HasMaxLength(150)
                    .HasColumnName("diseaseAllergies");

                entity.Property(e => e.Dm).HasColumnName("DM");

                entity.Property(e => e.DrugHxmaintenance)
                    .HasMaxLength(150)
                    .HasColumnName("Drug_HXMaintenance");

                entity.Property(e => e.DrugPlanManagement)
                    .HasMaxLength(150)
                    .HasColumnName("Drug_planManagement");

                entity.Property(e => e.EventConvulsion)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Convulsion");

                entity.Property(e => e.EventInfections)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Infections");

                entity.Property(e => e.EventMilestone)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Milestone");

                entity.Property(e => e.EventNotes)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Notes");

                entity.Property(e => e.EventOtherChronic)
                    .HasMaxLength(100)
                    .HasColumnName("Event_OtherChronic");

                entity.Property(e => e.EventSurgical)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Surgical");

                entity.Property(e => e.EventSymptoms)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Symptoms");

                entity.Property(e => e.EventTrauma)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Trauma");

                entity.Property(e => e.EventVaccinations)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Vaccinations");

                entity.Property(e => e.FhmHxsimilar)
                    .HasMaxLength(250)
                    .HasColumnName("FHM_HXSimilar");

                entity.Property(e => e.FhmOthers)
                    .HasMaxLength(250)
                    .HasColumnName("FHM_Others");

                entity.Property(e => e.FmhCardiac).HasColumnName("FMH_Cardiac");

                entity.Property(e => e.FmhDm).HasColumnName("FMH_DM");

                entity.Property(e => e.FmhHaematological).HasColumnName("FMH_Haematological");

                entity.Property(e => e.FmhHtn).HasColumnName("FMH_HTN");

                entity.Property(e => e.FmhRenal).HasColumnName("FMH_Renal");

                entity.Property(e => e.FmhRespiratory).HasColumnName("FMH_Respiratory");

                entity.Property(e => e.Gd).HasColumnName("GD");

                entity.Property(e => e.Htn).HasColumnName("HTN");

                entity.Property(e => e.Infections).HasMaxLength(150);

                entity.Property(e => e.LearningDifficulties).HasMaxLength(150);

                entity.Property(e => e.MainDiagnosisHistory).HasMaxLength(250);

                entity.Property(e => e.MedicalDiagnosis).HasMaxLength(250);

                entity.Property(e => e.ModeDelivery).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.NotesDuringDelivery).HasMaxLength(250);

                entity.Property(e => e.NotesHealthProb).HasMaxLength(250);

                entity.Property(e => e.OtherChronic).HasMaxLength(250);

                entity.Property(e => e.Pih).HasColumnName("PIH");

                entity.Property(e => e.PresentComplaints).HasMaxLength(250);

                entity.Property(e => e.PsychoTraumeAfter5Fyear)
                    .HasMaxLength(100)
                    .HasColumnName("Psycho_TraumeAfter5Fyear");

                entity.Property(e => e.PsychoTraumeInFyear)
                    .HasMaxLength(100)
                    .HasColumnName("Psycho_TraumeInFyear");

                entity.Property(e => e.PsychologicalHistory).HasMaxLength(150);

                entity.Property(e => e.SocialHParentsStatus)
                    .HasMaxLength(100)
                    .HasColumnName("SocialH_ParentsStatus");

                entity.Property(e => e.SocialHistory).HasMaxLength(150);

                entity.Property(e => e.SurgicalOperations).HasMaxLength(150);

                entity.Property(e => e.SymptomsDisability).HasMaxLength(250);

                entity.Property(e => e.Trauma).HasMaxLength(150);

                entity.Property(e => e.TypeDelivery).HasMaxLength(50);

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.MedicalHistories)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalHistory_MedicalAssessment");
            });

            modelBuilder.Entity<MedicalHospital>(entity =>
            {
                entity.HasKey(e => e.HospitalId);

                entity.ToTable("MedicalHospital");

                entity.Property(e => e.HospitalId).HasColumnName("HospitalID");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Telephone).HasMaxLength(150);
            });

            modelBuilder.Entity<MedicalHospitalVisit>(entity =>
            {
                entity.HasKey(e => e.VisitHospitalId);

                entity.ToTable("MedicalHospitalVisit");

                entity.Property(e => e.VisitHospitalId).HasColumnName("VisitHospitalID");

                entity.Property(e => e.ClinicDepartment).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Diagnosis).HasMaxLength(500);

                entity.Property(e => e.DoctorName).HasMaxLength(100);

                entity.Property(e => e.HospitalId).HasColumnName("HospitalID");

                entity.Property(e => e.Investigations).HasMaxLength(800);

                entity.Property(e => e.PlanManagement).HasMaxLength(800);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.VisitType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.MedicalHospitalVisits)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalHospitalVisit_MedicalHospital");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.MedicalHospitalVisits)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalHospitalVisit_Student");
            });

            modelBuilder.Entity<MedicalHospitalVisitAttach>(entity =>
            {
                entity.HasKey(e => e.VisitAttachmentId);

                entity.ToTable("MedicalHospitalVisitAttach");

                entity.Property(e => e.VisitAttachmentId).HasColumnName("VisitAttachmentID");

                entity.Property(e => e.InvestigationName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.VisitHospitalId).HasColumnName("VisitHospitalID");

                entity.HasOne(d => d.VisitHospital)
                    .WithMany(p => p.MedicalHospitalVisitAttaches)
                    .HasForeignKey(d => d.VisitHospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalHospitalVisitAttach_MedicalHospitalVisit");
            });

            modelBuilder.Entity<MedicalHospitalVisitDetail>(entity =>
            {
                entity.HasKey(e => e.VisitMedicationId);

                entity.ToTable("MedicalHospitalVisitDetail");

                entity.Property(e => e.VisitMedicationId).HasColumnName("VisitMedicationID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Dose)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FreqDay)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VisitHospitalId).HasColumnName("VisitHospitalID");

                entity.HasOne(d => d.Medication)
                    .WithMany(p => p.MedicalHospitalVisitDetails)
                    .HasForeignKey(d => d.MedicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalHospitalVisitDetail_MedicalMedicationName");

                entity.HasOne(d => d.VisitHospital)
                    .WithMany(p => p.MedicalHospitalVisitDetails)
                    .HasForeignKey(d => d.VisitHospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalHospitalVisitDetail_MedicalHospitalVisit");
            });

            modelBuilder.Entity<MedicalInstruction>(entity =>
            {
                entity.HasKey(e => e.InstructionId);

                entity.ToTable("MedicalInstruction");

                entity.Property(e => e.InstructionId).HasColumnName("InstructionID");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Instruction)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<MedicalMedicationName>(entity =>
            {
                entity.HasKey(e => e.MedicationId);

                entity.ToTable("MedicalMedicationName");

                entity.Property(e => e.MedicationName).HasMaxLength(200);
            });

            modelBuilder.Entity<MedicalMedicationStudent>(entity =>
            {
                entity.HasKey(e => e.MedicationStudentId);

                entity.ToTable("MedicalMedicationStudent");

                entity.Property(e => e.MedicationStudentId).HasColumnName("MedicationStudentID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.VisitHospitalId).HasColumnName("VisitHospitalID");
            });

            modelBuilder.Entity<MedicalMedicationStudentDetail>(entity =>
            {
                entity.HasKey(e => e.MedicationStudDelailId);

                entity.ToTable("MedicalMedicationStudentDetail");

                entity.Property(e => e.MedicationStudDelailId).HasColumnName("MedicationStudDelailID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Dose)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FreqDay)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MedicationStudentId).HasColumnName("MedicationStudentID");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Medication)
                    .WithMany(p => p.MedicalMedicationStudentDetails)
                    .HasForeignKey(d => d.MedicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalMedicationStudentDetail_MedicalMedicineName");

                entity.HasOne(d => d.MedicationStudent)
                    .WithMany(p => p.MedicalMedicationStudentDetails)
                    .HasForeignKey(d => d.MedicationStudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalMedicationStudentDetail_MedicalMedicationStudent");
            });

            modelBuilder.Entity<MedicalMedicineName>(entity =>
            {
                entity.HasKey(e => e.MedicationId);

                entity.ToTable("MedicalMedicineName");

                entity.Property(e => e.MedicationName).HasMaxLength(200);
            });

            modelBuilder.Entity<MedicalNurseAssessment>(entity =>
            {
                entity.HasKey(e => e.NurseAssessmnetId);

                entity.ToTable("MedicalNurseAssessment");

                entity.Property(e => e.NurseAssessmnetId).HasColumnName("NurseAssessmnetID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.Bp)
                    .HasMaxLength(50)
                    .HasColumnName("BP");

                entity.Property(e => e.ChiefComplaints).HasMaxLength(250);

                entity.Property(e => e.EyeOpening).HasMaxLength(50);

                entity.Property(e => e.GeneralAppearance).HasMaxLength(250);

                entity.Property(e => e.GlasgowComaScale).HasMaxLength(50);

                entity.Property(e => e.Height).HasMaxLength(50);

                entity.Property(e => e.MotorResponse).HasMaxLength(50);

                entity.Property(e => e.PainScore).HasMaxLength(50);

                entity.Property(e => e.Pulse).HasMaxLength(50);

                entity.Property(e => e.PulseCharacter).HasMaxLength(50);

                entity.Property(e => e.Respcharacter)
                    .HasMaxLength(50)
                    .HasColumnName("RESPCharacter");

                entity.Property(e => e.Rr)
                    .HasMaxLength(50)
                    .HasColumnName("RR");

                entity.Property(e => e.Spo2)
                    .HasMaxLength(50)
                    .HasColumnName("SPO2");

                entity.Property(e => e.Temp).HasMaxLength(50);

                entity.Property(e => e.VerbalResponse).HasMaxLength(50);

                entity.Property(e => e.Weight).HasMaxLength(50);

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.MedicalNurseAssessments)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalNurseAssessment_MedicalAssessment");
            });

            modelBuilder.Entity<MedicalNurseNote>(entity =>
            {
                entity.HasKey(e => e.NurseNoteId);

                entity.ToTable("MedicalNurseNote");

                entity.Property(e => e.NurseNoteId).HasColumnName("NurseNoteID");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.MedicalNurseNotes)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalNurseNote_Student");
            });

            modelBuilder.Entity<MedicalPhycicanAssessment>(entity =>
            {
                entity.HasKey(e => e.PhycicanAssessmentId);

                entity.ToTable("MedicalPhycicanAssessment");

                entity.Property(e => e.PhycicanAssessmentId).HasColumnName("PhycicanAssessmentID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.CardiovascularSystem).HasMaxLength(350);

                entity.Property(e => e.Cns)
                    .HasMaxLength(350)
                    .HasColumnName("CNS");

                entity.Property(e => e.Ent)
                    .HasMaxLength(350)
                    .HasColumnName("ENT");

                entity.Property(e => e.Git)
                    .HasMaxLength(350)
                    .HasColumnName("GIT");

                entity.Property(e => e.OphthalmicAssess).HasMaxLength(350);

                entity.Property(e => e.OtherRespiratory).HasMaxLength(350);

                entity.Property(e => e.Others).HasMaxLength(350);

                entity.Property(e => e.Recommendations).HasMaxLength(350);

                entity.Property(e => e.RespiratorySystem).HasMaxLength(350);

                entity.Property(e => e.Skin).HasMaxLength(350);

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.MedicalPhycicanAssessments)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalPhycicanAssessment_MedicalAssessment");
            });

            modelBuilder.Entity<NatAssesment>(entity =>
            {
                entity.HasKey(e => e.AssesmentId);

                entity.ToTable("NatAssesment");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.NoteContact).HasMaxLength(350);

                entity.Property(e => e.NoteDeepTendonR)
                    .HasMaxLength(350)
                    .HasColumnName("Note_DeepTendonR");

                entity.Property(e => e.NoteFunassessment)
                    .HasMaxLength(350)
                    .HasColumnName("Note_funassessment");

                entity.Property(e => e.NoteMmt)
                    .HasMaxLength(350)
                    .HasColumnName("Note_MMT");

                entity.Property(e => e.NoteMuscleTone).HasMaxLength(350);

                entity.Property(e => e.NoteNervousSys).HasMaxLength(350);

                entity.Property(e => e.NoteRom)
                    .HasMaxLength(350)
                    .HasColumnName("Note_ROM");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NatAssesments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatAssesment_Student");
            });

            modelBuilder.Entity<NatAssesmentItem>(entity =>
            {
                entity.HasKey(e => e.AssesmentItemId)
                    .HasName("PK_AssesmentItem");

                entity.ToTable("NatAssesmentItem");

                entity.Property(e => e.AssesmentItemId).HasColumnName("AssesmentItemID");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemValueId).HasColumnName("ItemValueID");

                entity.HasOne(d => d.Assesment)
                    .WithMany(p => p.NatAssesmentItems)
                    .HasForeignKey(d => d.AssesmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatAssesmentItem_NatAssesment");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.NatAssesmentItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatAssesmentItem_NatItem");

                entity.HasOne(d => d.ItemValue)
                    .WithMany(p => p.NatAssesmentItems)
                    .HasForeignKey(d => d.ItemValueId)
                    .HasConstraintName("FK_NatAssesmentItem_NatItemValue");
            });

            modelBuilder.Entity<NatAssesmentRom>(entity =>
            {
                entity.HasKey(e => e.AssesmentRomid);

                entity.ToTable("NatAssesmentROM");

                entity.Property(e => e.AssesmentRomid).HasColumnName("AssesmentROMID");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CurrentRom).HasColumnName("CurrentROM");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_Active")
                    .HasComment("1-Active\r\n0-Passive");

                entity.Property(e => e.ItemRomId).HasColumnName("ItemRomID");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.Romid).HasColumnName("ROMID");

                entity.Property(e => e.Slide).HasComment("0-left\r\n1-right");

                entity.Property(e => e.Strength).HasMaxLength(350);

                entity.HasOne(d => d.Assesment)
                    .WithMany(p => p.NatAssesmentRoms)
                    .HasForeignKey(d => d.AssesmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatAssesmentROM_NatAssesment");

                entity.HasOne(d => d.ItemRom)
                    .WithMany(p => p.NatAssesmentRoms)
                    .HasForeignKey(d => d.ItemRomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatAssesmentROM_NatROM");
            });

            modelBuilder.Entity<NatItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("NatItem");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemGrpId).HasColumnName("ItemGrpID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.ItemGrp)
                    .WithMany(p => p.NatItems)
                    .HasForeignKey(d => d.ItemGrpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatItem_NatItemGroup");
            });

            modelBuilder.Entity<NatItemGroup>(entity =>
            {
                entity.HasKey(e => e.ItemGrpId);

                entity.ToTable("NatItemGroup");

                entity.Property(e => e.ItemGrpId).HasColumnName("ItemGrpID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<NatItemValue>(entity =>
            {
                entity.HasKey(e => e.ItemValueId);

                entity.ToTable("NatItemValue");

                entity.Property(e => e.ItemValueId).HasColumnName("ItemValueID");

                entity.Property(e => e.ItemGrpId).HasColumnName("ItemGrpID");

                entity.Property(e => e.ItemValue)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.ItemGrp)
                    .WithMany(p => p.NatItemValues)
                    .HasForeignKey(d => d.ItemGrpId)
                    .HasConstraintName("FK_NatItemValue_NatItem");
            });

            modelBuilder.Entity<NatItemValueGrp>(entity =>
            {
                entity.HasKey(e => e.ItemValuegrpId);

                entity.ToTable("NatItemValueGrp");

                entity.Property(e => e.ItemValuegrpId).HasColumnName("ItemValuegrpID");

                entity.Property(e => e.ItemGrpId).HasColumnName("ItemGrpID");

                entity.Property(e => e.ItemValueId).HasColumnName("ItemValueID");
            });

            modelBuilder.Entity<NatProgStudent>(entity =>
            {
                entity.HasKey(e => e.ProgStudentId);

                entity.ToTable("NatProgStudent");

                entity.Property(e => e.ProgStudentId).HasColumnName("ProgStudentID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NatProgStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatProgStudent_Student");
            });

            modelBuilder.Entity<NatProgStudentDetail>(entity =>
            {
                entity.HasKey(e => e.ProgStudDetailId);

                entity.Property(e => e.ProgStudDetailId).HasColumnName("ProgStudDetailID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.ProgStudentId).HasColumnName("ProgStudentID");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.ProgStudent)
                    .WithMany(p => p.NatProgStudentDetails)
                    .HasForeignKey(d => d.ProgStudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatProgStudentDetails_NatProgStudent");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.NatProgStudentDetails)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatProgStudentDetails_NatProgram");
            });

            modelBuilder.Entity<NatProgram>(entity =>
            {
                entity.HasKey(e => e.ProgramId);

                entity.ToTable("NatProgram");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<NatRom>(entity =>
            {
                entity.HasKey(e => e.Romid);

                entity.ToTable("NatROM");

                entity.Property(e => e.Romid).HasColumnName("ROMID");

                entity.Property(e => e.Department).HasComment("تحديد القسم\r\n1-العلاج الطبيعى\r\n2- العلاج الوظيفى");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Romname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ROMName");
            });

            modelBuilder.Entity<NatRomitem>(entity =>
            {
                entity.HasKey(e => e.ItemRomId);

                entity.ToTable("NatROMItem");

                entity.Property(e => e.ItemRomId).HasColumnName("ItemRomID");

                entity.Property(e => e.ItemRomName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NormalValue).HasMaxLength(100);

                entity.Property(e => e.Romid).HasColumnName("ROMID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Rom)
                    .WithMany(p => p.NatRomitems)
                    .HasForeignKey(d => d.Romid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatROMItem_NatROM");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NatRomitems)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_NatROMItem_Student");
            });

            modelBuilder.Entity<NatStudentReport>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("NatStudentReport");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Details).IsRequired();

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.CreatebyNavigation)
                    .WithMany(p => p.NatStudentReports)
                    .HasForeignKey(d => d.Createby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatStudentReport_User");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NatStudentReports)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatStudentReport_Student");
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationality");

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(250);
            });

            modelBuilder.Entity<Notifcation>(entity =>
            {
                entity.ToTable("Notifcation");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Details).HasMaxLength(500);

                entity.Property(e => e.FromDepId).HasColumnName("fromDepID");

                entity.Property(e => e.FromUserId).HasColumnName("FromUserID");

                entity.Property(e => e.IsDeleted).HasColumnName("IS_Deleted");

                entity.Property(e => e.IsRead).HasColumnName("IS_read");

                entity.Property(e => e.Parm1Key).HasMaxLength(50);

                entity.Property(e => e.Parm1Value)
                    .HasMaxLength(50)
                    .HasColumnName("parm1Value");

                entity.Property(e => e.Parm2Key).HasMaxLength(50);

                entity.Property(e => e.Parm2Value2)
                    .HasMaxLength(50)
                    .HasColumnName("parm2Value2");

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<NutiActivityLevel>(entity =>
            {
                entity.HasKey(e => e.ActivityLevelId);

                entity.ToTable("NutiActivityLevel");

                entity.Property(e => e.ActivityLevelId).HasColumnName("ActivityLevelID");

                entity.Property(e => e.ActivityLevel)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<NutiAssesment>(entity =>
            {
                entity.HasKey(e => e.AssesmentId);

                entity.ToTable("NutiAssesment");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.ActivityLevelId).HasColumnName("ActivityLevelID");

                entity.Property(e => e.Attachment).HasMaxLength(150);

                entity.Property(e => e.Cho)
                    .HasMaxLength(50)
                    .HasColumnName("cho");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DietId).HasColumnName("DietID");

                entity.Property(e => e.Fats).HasMaxLength(50);

                entity.Property(e => e.Habits).HasMaxLength(150);

                entity.Property(e => e.IsActive).HasColumnName("IS_Active");

                entity.Property(e => e.PhysicActivityId).HasColumnName("PhysicActivityID");

                entity.Property(e => e.Physictherapy).HasMaxLength(50);

                entity.Property(e => e.Pro).HasMaxLength(50);

                entity.Property(e => e.RequirementKca)
                    .HasMaxLength(50)
                    .HasColumnName("RequirementKCA");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TexturesfoodId).HasColumnName("TexturesfoodID");

                entity.Property(e => e.WaterInk)
                    .HasMaxLength(50)
                    .HasColumnName("waterInk");

                entity.HasOne(d => d.Diet)
                    .WithMany(p => p.NutiAssesments)
                    .HasForeignKey(d => d.DietId)
                    .HasConstraintName("FK_NutiAssesment_NutiDiet");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NutiAssesments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiAssesment_Student");

                entity.HasOne(d => d.Texturesfood)
                    .WithMany(p => p.NutiAssesments)
                    .HasForeignKey(d => d.TexturesfoodId)
                    .HasConstraintName("FK_NutiAssesment_NutiTexturesfood");
            });

            modelBuilder.Entity<NutiAssesmentMin>(entity =>
            {
                entity.HasKey(e => e.AssesmentMinId);

                entity.ToTable("NutiAssesmentMin");

                entity.Property(e => e.AssesmentMinId)
                    .ValueGeneratedNever()
                    .HasColumnName("assesmentMinID");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.MinId).HasColumnName("MinID");

                entity.HasOne(d => d.Assesment)
                    .WithMany(p => p.NutiAssesmentMins)
                    .HasForeignKey(d => d.AssesmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiAssesmentMin_NutiAssesment");

                entity.HasOne(d => d.Min)
                    .WithMany(p => p.NutiAssesmentMins)
                    .HasForeignKey(d => d.MinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiAssesmentMin_NutiMin");
            });

            modelBuilder.Entity<NutiAssesmentVitimin>(entity =>
            {
                entity.HasKey(e => e.AssesmentVitId);

                entity.ToTable("NutiAssesmentVitimin");

                entity.Property(e => e.AssesmentVitId).HasColumnName("AssesmentVitID");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.VitimId).HasColumnName("VitimID");

                entity.HasOne(d => d.Assesment)
                    .WithMany(p => p.NutiAssesmentVitimins)
                    .HasForeignKey(d => d.AssesmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiAssesmentVitimin_NutiAssesment");

                entity.HasOne(d => d.Vitim)
                    .WithMany(p => p.NutiAssesmentVitimins)
                    .HasForeignKey(d => d.VitimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiAssesmentVitimin_NutiVitimin");
            });

            modelBuilder.Entity<NutiAssessmentStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NutiAssessmentStudent");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CareGiver).HasMaxLength(250);

                entity.Property(e => e.DateRegister).HasColumnType("smalldatetime");

                entity.Property(e => e.MedicalDiagnosis).HasMaxLength(350);

                entity.Property(e => e.NationalityName).HasMaxLength(250);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionName).HasMaxLength(150);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SuperVisouer).HasMaxLength(250);
            });

            modelBuilder.Entity<NutiBaseIngredient>(entity =>
            {
                entity.HasKey(e => e.IngredientId)
                    .HasName("PK_NutrFoodIngredient");

                entity.ToTable("NutiBaseIngredient");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IngredientName).HasMaxLength(150);
            });

            modelBuilder.Entity<NutiBcastudent>(entity =>
            {
                entity.HasKey(e => e.Bcaid);

                entity.ToTable("NutiBCAStudent");

                entity.Property(e => e.Bcaid).HasColumnName("BCAID");

                entity.Property(e => e.Attachment).HasMaxLength(250);

                entity.Property(e => e.Bmi).HasColumnName("BMI");

                entity.Property(e => e.Bmrid).HasColumnName("BMRID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Ecwl)
                    .HasMaxLength(50)
                    .HasColumnName("ECWL");

                entity.Property(e => e.Ecwlnrange)
                    .HasMaxLength(50)
                    .HasColumnName("ECWLNRange");

                entity.Property(e => e.Icwl).HasColumnName("ICWL");

                entity.Property(e => e.Icwlnrange)
                    .HasMaxLength(50)
                    .HasColumnName("ICWLNRange");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Bmr)
                    .WithMany(p => p.NutiBcastudents)
                    .HasForeignKey(d => d.Bmrid)
                    .HasConstraintName("FK_NutiBCAStudent_NutiBMR");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NutiBcastudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiBCAStudent_Student");
            });

            modelBuilder.Entity<NutiBmr>(entity =>
            {
                entity.HasKey(e => e.Bmrid);

                entity.ToTable("NutiBMR");

                entity.Property(e => e.Bmrid).HasColumnName("BMRID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Mbrname)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("MBRName");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<NutiDientPlan>(entity =>
            {
                entity.HasKey(e => e.DietPlanId);

                entity.ToTable("NutiDientPlan");

                entity.Property(e => e.DietPlanId).HasColumnName("DietPlanID");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DietId).HasColumnName("DietID");

                entity.HasOne(d => d.Diet)
                    .WithMany(p => p.NutiDientPlans)
                    .HasForeignKey(d => d.DietId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiDientPlan_NutiDiet");
            });

            modelBuilder.Entity<NutiDiet>(entity =>
            {
                entity.HasKey(e => e.DietId);

                entity.ToTable("NutiDiet");

                entity.Property(e => e.DietId).HasColumnName("DietID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DietName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<NutiDietPlanDet>(entity =>
            {
                entity.HasKey(e => e.DietPlanDetId);

                entity.ToTable("NutiDietPlanDet");

                entity.Property(e => e.DietPlanDetId).HasColumnName("DietPlanDetID");

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DietPlanId).HasColumnName("DietPlanID");

                entity.Property(e => e.MealTimeId).HasColumnName("MealTimeID");

                entity.HasOne(d => d.DietPlan)
                    .WithMany(p => p.NutiDietPlanDets)
                    .HasForeignKey(d => d.DietPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiDietPlanDet_NutiDientPlan");

                entity.HasOne(d => d.MealTime)
                    .WithMany(p => p.NutiDietPlanDets)
                    .HasForeignKey(d => d.MealTimeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiDietPlanDet_NutiMealTime");
            });

            modelBuilder.Entity<NutiFood>(entity =>
            {
                entity.HasKey(e => e.FoodId);

                entity.ToTable("NutiFood");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.Calories).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Measure).HasMaxLength(50);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.UniteId).HasColumnName("UniteID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.NutiFoods)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFood_NutiFoodGroup");

                entity.HasOne(d => d.Unite)
                    .WithMany(p => p.NutiFoods)
                    .HasForeignKey(d => d.UniteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFood_NutiFoodUnite");
            });

            modelBuilder.Entity<NutiFoodGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_NutrFoodGroup");

                entity.ToTable("NutiFoodGroup");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<NutiFoodIngredient>(entity =>
            {
                entity.HasKey(e => e.FodIngredientId);

                entity.ToTable("NutiFoodIngredient");

                entity.Property(e => e.FodIngredientId).HasColumnName("FodIngredientID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.NutiFoodIngredients)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFoodIngredient_NutiFood");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.NutiFoodIngredients)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFoodIngredient_NutiBaseIngredient");
            });

            modelBuilder.Entity<NutiFoodIntolerance>(entity =>
            {
                entity.HasKey(e => e.FodIntoleranceId)
                    .HasName("PK_NutiFodIntolerance");

                entity.ToTable("NutiFoodIntolerance");

                entity.Property(e => e.FodIntoleranceId).HasColumnName("FodIntoleranceID");

                entity.Property(e => e.Attachment).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<NutiFoodIntoleranceDet>(entity =>
            {
                entity.HasKey(e => e.IntoleranceDetId);

                entity.ToTable("NutiFoodIntoleranceDet");

                entity.Property(e => e.IntoleranceDetId).HasColumnName("IntoleranceDetID");

                entity.Property(e => e.FodIntoleranceId).HasColumnName("FodIntoleranceID");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.HasOne(d => d.FodIntolerance)
                    .WithMany(p => p.NutiFoodIntoleranceDets)
                    .HasForeignKey(d => d.FodIntoleranceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFoodIntoleranceDet_NutiFoodIntolerance");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.NutiFoodIntoleranceDets)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFoodIntoleranceDet_NutiBaseIngredient");
            });

            modelBuilder.Entity<NutiFoodMealType>(entity =>
            {
                entity.HasKey(e => e.FodMealTypeId);

                entity.ToTable("NutiFoodMealType");

                entity.Property(e => e.FodMealTypeId).HasColumnName("FodMealTypeID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.MealTypeId).HasColumnName("MealTypeID");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.NutiFoodMealTypes)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFoodMealType_NutiFood");

                entity.HasOne(d => d.MealType)
                    .WithMany(p => p.NutiFoodMealTypes)
                    .HasForeignKey(d => d.MealTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFoodMealType_NutiMealType");
            });

            modelBuilder.Entity<NutiFoodPrefernce>(entity =>
            {
                entity.HasKey(e => e.FodPrefernceId);

                entity.ToTable("NutiFoodPrefernce");

                entity.Property(e => e.FodPrefernceId).HasColumnName("FodPrefernceID");

                entity.Property(e => e.Attachment).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NutiFoodPrefernces)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFoodPrefernce_Student");
            });

            modelBuilder.Entity<NutiFoodPrefernceDet>(entity =>
            {
                entity.HasKey(e => e.FodPrefernceDetId);

                entity.ToTable("NutiFoodPrefernceDet");

                entity.Property(e => e.FodPrefernceDetId).HasColumnName("FodPrefernceDetID");

                entity.Property(e => e.FodPrefernceId).HasColumnName("FodPrefernceID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.IsLike).HasColumnName("IS_like");

                entity.HasOne(d => d.FodPrefernce)
                    .WithMany(p => p.NutiFoodPrefernceDets)
                    .HasForeignKey(d => d.FodPrefernceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFoodPrefernceDet_NutiFoodPrefernce");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.NutiFoodPrefernceDets)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiFoodPrefernceDet_NutiFood");
            });

            modelBuilder.Entity<NutiFoodUnite>(entity =>
            {
                entity.HasKey(e => e.UniteId);

                entity.ToTable("NutiFoodUnite");

                entity.Property(e => e.UniteId).HasColumnName("UniteID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.UniteName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<NutiMealTime>(entity =>
            {
                entity.HasKey(e => e.MealTimeId);

                entity.ToTable("NutiMealTime");

                entity.Property(e => e.MealTimeId).HasColumnName("MealTimeID");

                entity.Property(e => e.Am)
                    .HasMaxLength(20)
                    .HasColumnName("AM");

                entity.Property(e => e.MealName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MealTypeId).HasColumnName("MealTypeID");

                entity.HasOne(d => d.MealType)
                    .WithMany(p => p.NutiMealTimes)
                    .HasForeignKey(d => d.MealTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiMealTime_NutiMealType");
            });

            modelBuilder.Entity<NutiMealTimeFood>(entity =>
            {
                entity.HasKey(e => e.MealTimeFoodId);

                entity.ToTable("NutiMealTimeFood");

                entity.Property(e => e.MealTimeFoodId).HasColumnName("MealTimeFoodID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.MealTimeId).HasColumnName("MealTimeID");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.NutiMealTimeFoods)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiMealTimeFood_NutiFood");

                entity.HasOne(d => d.MealTime)
                    .WithMany(p => p.NutiMealTimeFoods)
                    .HasForeignKey(d => d.MealTimeId)
                    .HasConstraintName("FK_NutiMealTimeFood_NutiMealTime");
            });

            modelBuilder.Entity<NutiMealTimeTable>(entity =>
            {
                entity.HasKey(e => e.MealTimeTabId);

                entity.ToTable("NutiMealTimeTable");

                entity.Property(e => e.MealTimeTabId).HasColumnName("MealTimeTabID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Attachment).HasMaxLength(250);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DietId).HasColumnName("DietID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Diet)
                    .WithMany(p => p.NutiMealTimeTables)
                    .HasForeignKey(d => d.DietId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiMealTimeTable_NutiDiet");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.NutiMealTimeTables)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiMealTimeTable_NutiMealTimeTable");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NutiMealTimeTables)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiMealTimeTable_Student");
            });

            modelBuilder.Entity<NutiMealType>(entity =>
            {
                entity.HasKey(e => e.MealTypeId);

                entity.ToTable("NutiMealType");

                entity.Property(e => e.MealTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MealTypeID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MealName).HasMaxLength(100);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<NutiMin>(entity =>
            {
                entity.HasKey(e => e.MinId);

                entity.ToTable("NutiMin");

                entity.Property(e => e.MinId).HasColumnName("MinID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MinName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<NutiOrientation>(entity =>
            {
                entity.HasKey(e => e.OrientId);

                entity.ToTable("NutiOrientation");

                entity.Property(e => e.OrientId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrientID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(350);

                entity.Property(e => e.IsIndividual)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Individual");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NutiOrientations)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiOrientation_Student");
            });

            modelBuilder.Entity<NutiPhysicalActivity>(entity =>
            {
                entity.HasKey(e => e.PhysicActivityId);

                entity.ToTable("NutiPhysicalActivity");

                entity.Property(e => e.PhysicActivityId).HasColumnName("PhysicActivityID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PhysicName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("physicName");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<NutiPlanStudent>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("NutiPlanStudent");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(350);

                entity.Property(e => e.Recomandation).HasMaxLength(450);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.NutiPlanStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutiPlanStudent_Student");
            });

            modelBuilder.Entity<NutiTexturesfood>(entity =>
            {
                entity.HasKey(e => e.TexturesfoodId);

                entity.ToTable("NutiTexturesfood");

                entity.Property(e => e.TexturesfoodId).HasColumnName("TexturesfoodID");

                entity.Property(e => e.Texturesfood)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<NutiVitimin>(entity =>
            {
                entity.HasKey(e => e.VitimId);

                entity.ToTable("NutiVitimin");

                entity.Property(e => e.VitimId).HasColumnName("VitimID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.VitimName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OccuAssessment>(entity =>
            {
                entity.HasKey(e => e.AssesmentId);

                entity.ToTable("OccuAssessment");

                entity.Property(e => e.AssesmentId)
                    .HasColumnName("AssesmentID")
                    .HasComment("مسلسل تقييم العلاج الوظيفى");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ التقييم");

                entity.Property(e => e.IsFirstAssement)
                    .HasColumnName("IS_FirstAssement")
                    .HasComment("هل التقييم الاول\r\nاذا كان بنعم سوف يسجل بياناتها فى جدول اخر");

                entity.Property(e => e.Notes)
                    .HasMaxLength(350)
                    .HasComment("التوصياتو ملاحظات التقييم");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasComment("مسلسل اللغة");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasComment("مسلسل الطالب");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.OccuAssessments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OccuAssessment_Student");
            });

            modelBuilder.Entity<OccuAssessment1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OccuAssessments");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AnyOtherDiseases).HasMaxLength(50);

                entity.Property(e => e.AssementFirstId).HasColumnName("AssementFirstID");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.BeginSymptoms)
                    .HasMaxLength(150)
                    .HasColumnName("beginSymptoms");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Drugs).HasMaxLength(350);

                entity.Property(e => e.Edema).HasMaxLength(150);

                entity.Property(e => e.IsFirstAssement).HasColumnName("IS_FirstAssement");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.NotesFirstAssement).HasMaxLength(350);

                entity.Property(e => e.PainDuringRest).HasMaxLength(150);

                entity.Property(e => e.Period).HasMaxLength(50);

                entity.Property(e => e.QualityDelivery).HasMaxLength(150);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TherapistSessionsPtOt).HasMaxLength(150);
            });

            modelBuilder.Entity<OccuAssessmentFirstEva>(entity =>
            {
                entity.HasKey(e => e.AssementFirstId);

                entity.ToTable("OccuAssessmentFirstEva");

                entity.Property(e => e.AssementFirstId).HasColumnName("AssementFirstID");

                entity.Property(e => e.AnyOtherDiseases).HasMaxLength(50);

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.BeginSymptoms)
                    .HasMaxLength(150)
                    .HasColumnName("beginSymptoms");

                entity.Property(e => e.Drugs).HasMaxLength(350);

                entity.Property(e => e.Edema).HasMaxLength(150);

                entity.Property(e => e.NotesFirstAssement).HasMaxLength(350);

                entity.Property(e => e.PainDuringRest).HasMaxLength(150);

                entity.Property(e => e.Period).HasMaxLength(50);

                entity.Property(e => e.QualityDelivery).HasMaxLength(150);

                entity.Property(e => e.TherapistSessionsPtOt).HasMaxLength(150);

                entity.HasOne(d => d.Assesment)
                    .WithMany(p => p.OccuAssessmentFirstEvas)
                    .HasForeignKey(d => d.AssesmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OccuAssessmentFirstEva_OccuAssessment");
            });

            modelBuilder.Entity<OccuAssessmentRom>(entity =>
            {
                entity.HasKey(e => e.RomAssementId);

                entity.ToTable("OccuAssessmentROM");

                entity.Property(e => e.RomAssementId)
                    .HasColumnName("RomAssementID")
                    .HasComment("مسلسل نتائج ROM");

                entity.Property(e => e.AssesmentId)
                    .HasColumnName("AssesmentID")
                    .HasComment("مسلسل التقييم");

                entity.Property(e => e.Evaluation)
                    .HasMaxLength(150)
                    .HasComment("مسلسل نتيجة النتقييم");

                entity.Property(e => e.ItemRomId)
                    .HasColumnName("ItemRomID")
                    .HasComment("مسلسل بند او عنصر التقيم");

                entity.Property(e => e.ReEvaluation)
                    .HasMaxLength(150)
                    .HasComment("مسلسل اعادة نتيجة التقييم");

                entity.HasOne(d => d.Assesment)
                    .WithMany(p => p.OccuAssessmentRoms)
                    .HasForeignKey(d => d.AssesmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OccuAssessmentROM_OccuAssessment");

                entity.HasOne(d => d.ItemRom)
                    .WithMany(p => p.OccuAssessmentRoms)
                    .HasForeignKey(d => d.ItemRomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OccuAssessmentROM_NatROMItem");
            });

            modelBuilder.Entity<OccuEvaluationValue>(entity =>
            {
                entity.HasKey(e => e.EvaluationValueId);

                entity.ToTable("OccuEvaluationValue");

                entity.Property(e => e.EvaluationValueId)
                    .HasColumnName("EvaluationValueID")
                    .HasComment("مسلسل قيم التقييم");

                entity.Property(e => e.EvaluationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مسمى قيمة التقييم");

                entity.Property(e => e.Romid).HasColumnName("ROMID");

                entity.HasOne(d => d.Rom)
                    .WithMany(p => p.OccuEvaluationValues)
                    .HasForeignKey(d => d.Romid)
                    .HasConstraintName("FK_OccuEvaluationValue_NatROM");
            });

            modelBuilder.Entity<OccuLongShortTarg>(entity =>
            {
                entity.HasKey(e => e.LongShortTargId);

                entity.ToTable("OccuLongShortTarg");

                entity.Property(e => e.LongShortTargId).HasColumnName("LongShortTargID");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.ShortTargetId).HasColumnName("ShortTargetID");

                entity.HasOne(d => d.LongTarget)
                    .WithMany(p => p.OccuLongShortTargs)
                    .HasForeignKey(d => d.LongTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OccuLongShortTarg_OccuPlanLongTarget");

                entity.HasOne(d => d.ShortTarget)
                    .WithMany(p => p.OccuLongShortTargs)
                    .HasForeignKey(d => d.ShortTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OccuLongShortTarg_OccuShortTarget");
            });

            modelBuilder.Entity<OccuLongTargCurStatu>(entity =>
            {
                entity.HasKey(e => e.CurrentStatusId);

                entity.ToTable("OccuLongTargCurStatu");

                entity.Property(e => e.CurrentStatusId).HasColumnName("CurrentStatusID");

                entity.Property(e => e.CurrentStatus)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<OccuLongTargRecomend>(entity =>
            {
                entity.HasKey(e => e.RecomendationId);

                entity.ToTable("OccuLongTargRecomend");

                entity.Property(e => e.RecomendationId).HasColumnName("RecomendationID");

                entity.Property(e => e.Recomendation).HasMaxLength(250);
            });

            modelBuilder.Entity<OccuMethod>(entity =>
            {
                entity.HasKey(e => e.MethodId);

                entity.ToTable("OccuMethod");

                entity.Property(e => e.MethodId).HasColumnName("MethodID");

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<OccuPlan>(entity =>
            {
                entity.HasKey(e => e.PlanTermId);

                entity.ToTable("OccuPlan");

                entity.Property(e => e.PlanTermId).HasColumnName("planTermID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ بداية الخطة");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasComment("مسلسل الطالب");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.OccuPlans)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OccuPlan_Student");
            });

            modelBuilder.Entity<OccuPlanLongTarget>(entity =>
            {
                entity.HasKey(e => e.LongTargetId);

                entity.ToTable("OccuPlanLongTarget");

                entity.Property(e => e.LongTargetId)
                    .HasColumnName("LongTargetID")
                    .HasComment("مسلسل الهدف طويل المدى");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CurrentStatusId).HasColumnName("CurrentStatusID");

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("الهدف طويل المدى");

                entity.Property(e => e.MethodId).HasColumnName("MethodID");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.PlanTermId)
                    .HasColumnName("planTermID")
                    .HasComment("مسمسل الخطة التربيوية\r\nفى حالة عدم ادخال مسلسل خطة تربية سوف يكون الهدف هنا نموذج للاهداف يمكن تمريره للطلاب بعد ذلك عند اختياره");

                entity.Property(e => e.Recomendation).HasMaxLength(350);

                entity.Property(e => e.RecomendationId).HasColumnName("RecomendationID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.ToolsId)
                    .HasColumnName("ToolsID")
                    .HasComment("مسلسل المجال");

                entity.HasOne(d => d.CurrentStatus)
                    .WithMany(p => p.OccuPlanLongTargets)
                    .HasForeignKey(d => d.CurrentStatusId)
                    .HasConstraintName("FK_OccuPlanLongTarget_OccuLongTargCurStatu");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.OccuPlanLongTargets)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_OccuPlanLongTarget_OccuMethod");

                entity.HasOne(d => d.PlanTerm)
                    .WithMany(p => p.OccuPlanLongTargets)
                    .HasForeignKey(d => d.PlanTermId)
                    .HasConstraintName("FK_OccuPlanLongTarget_OccuPlan");

                entity.HasOne(d => d.RecomendationNavigation)
                    .WithMany(p => p.OccuPlanLongTargets)
                    .HasForeignKey(d => d.RecomendationId)
                    .HasConstraintName("FK_OccuPlanLongTarget_OccuLongTargRecomend");

                entity.HasOne(d => d.Tools)
                    .WithMany(p => p.OccuPlanLongTargets)
                    .HasForeignKey(d => d.ToolsId)
                    .HasConstraintName("FK_OccuPlanLongTarget_OccuTool");
            });

            modelBuilder.Entity<OccuReportStudent>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("OccuReportStudent");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.OccuReportStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OccuReportStudent_Student");
            });

            modelBuilder.Entity<OccuShortTarget>(entity =>
            {
                entity.HasKey(e => e.ShortTargetId);

                entity.ToTable("OccuShortTarget");

                entity.Property(e => e.ShortTargetId)
                    .HasColumnName("ShortTargetID")
                    .HasComment("مسلسل الهدف قصير المدى");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.ShortTargetName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("مسمى الهدف قصير المدى");
            });

            modelBuilder.Entity<OccuTool>(entity =>
            {
                entity.HasKey(e => e.ToolsId);

                entity.ToTable("OccuTool");

                entity.Property(e => e.ToolsId).HasColumnName("ToolsID");

                entity.Property(e => e.ToolName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<PronAchievement>(entity =>
            {
                entity.HasKey(e => e.AchievementId);

                entity.ToTable("PronAchievement");

                entity.Property(e => e.AchievementId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AchievementID");

                entity.Property(e => e.Achievement).HasMaxLength(100);
            });

            modelBuilder.Entity<PronAssessment>(entity =>
            {
                entity.HasKey(e => e.AssessmentId);

                entity.ToTable("PronAssessment");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.AttentConcentration).HasMaxLength(50);

                entity.Property(e => e.AttentConcentrationDesc).HasMaxLength(150);

                entity.Property(e => e.AttractAttention).HasMaxLength(50);

                entity.Property(e => e.AttractAttentionDesc).HasMaxLength(150);

                entity.Property(e => e.BegfirstWord).HasMaxLength(50);

                entity.Property(e => e.BehDuringAssessment).HasMaxLength(350);

                entity.Property(e => e.CanRecoizeVoice)
                    .HasMaxLength(50)
                    .HasColumnName("canRecoizeVoice");

                entity.Property(e => e.CommthroMoveGestureDesc).HasMaxLength(250);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DirectionSound).HasMaxLength(50);

                entity.Property(e => e.ExpressiveSummary).HasMaxLength(250);

                entity.Property(e => e.EyeContact).HasMaxLength(50);

                entity.Property(e => e.EyeContactDesc).HasMaxLength(150);

                entity.Property(e => e.GesturesSummary).HasMaxLength(250);

                entity.Property(e => e.HasArticulationPhonic).HasMaxLength(50);

                entity.Property(e => e.HasNasalityDisorders).HasMaxLength(50);

                entity.Property(e => e.HasNasalityDisordersDesc).HasMaxLength(150);

                entity.Property(e => e.HasSpeechEcholalia).HasMaxLength(50);

                entity.Property(e => e.HasSuttering).HasMaxLength(50);

                entity.Property(e => e.HasSutteringDesc).HasMaxLength(150);

                entity.Property(e => e.HasVoiceDisorder).HasMaxLength(50);

                entity.Property(e => e.HasVoiceDisorderDesc).HasMaxLength(150);

                entity.Property(e => e.HascongenitalDefect).HasMaxLength(50);

                entity.Property(e => e.ImitationMotor).HasMaxLength(50);

                entity.Property(e => e.ImitationMotorDesc).HasMaxLength(150);

                entity.Property(e => e.ImitationVoice).HasMaxLength(50);

                entity.Property(e => e.ImitationVoiceDesc).HasMaxLength(150);

                entity.Property(e => e.IsAphasia)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Aphasia");

                entity.Property(e => e.IsApraxia)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Apraxia");

                entity.Property(e => e.IsDysarthia)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Dysarthia");

                entity.Property(e => e.KnowSound)
                    .HasMaxLength(50)
                    .HasColumnName("knowSound");

                entity.Property(e => e.MoveDesc).HasMaxLength(150);

                entity.Property(e => e.ObservationAssessment).HasMaxLength(350);

                entity.Property(e => e.ReceptiveSummry).HasMaxLength(250);

                entity.Property(e => e.RecognizeSound).HasMaxLength(50);

                entity.Property(e => e.Recomendation).HasMaxLength(350);

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SimpleInstructionsDesc).HasMaxLength(250);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.ThreeWordSentenceConve).HasMaxLength(100);

                entity.Property(e => e.ThreeWordSentenceDesc).HasMaxLength(100);

                entity.Property(e => e.TurnTakingDurPlaying).HasMaxLength(50);

                entity.Property(e => e.TurnTakingDurPlayingDesc).HasMaxLength(150);

                entity.Property(e => e.TwoWordSentenceConve).HasMaxLength(100);

                entity.Property(e => e.TwoWordSentenceDesc).HasMaxLength(100);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PronAssessments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessment_Student");
            });

            modelBuilder.Entity<PronAssessmentInstruction>(entity =>
            {
                entity.HasKey(e => e.AssessmentInstId);

                entity.ToTable("PronAssessmentInstruction");

                entity.Property(e => e.AssessmentInstId).HasColumnName("AssessmentInstID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.InstructionId).HasColumnName("InstructionID");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.PronAssessmentInstructions)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessmentInstruction_PronAssessment");

                entity.HasOne(d => d.Instruction)
                    .WithMany(p => p.PronAssessmentInstructions)
                    .HasForeignKey(d => d.InstructionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessmentInstruction_PronInstruction");
            });

            modelBuilder.Entity<PronAssessmentMove>(entity =>
            {
                entity.HasKey(e => e.AssessmentMoveId);

                entity.ToTable("PronAssessmentMove");

                entity.Property(e => e.AssessmentMoveId).HasColumnName("AssessmentMoveID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.MovementId).HasColumnName("MovementID");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.PronAssessmentMoves)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessmentMove_PronAssessment");

                entity.HasOne(d => d.Movement)
                    .WithMany(p => p.PronAssessmentMoves)
                    .HasForeignKey(d => d.MovementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessmentMove_PronMovement");
            });

            modelBuilder.Entity<PronAssessmentOrofacialExam>(entity =>
            {
                entity.HasKey(e => e.OrofacialExamId);

                entity.ToTable("PronAssessmentOrofacialExam");

                entity.Property(e => e.OrofacialExamId).HasColumnName("OrofacialExamID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.ControlThroat).HasMaxLength(150);

                entity.Property(e => e.Jaws).HasMaxLength(50);

                entity.Property(e => e.JawsDescrib).HasMaxLength(250);

                entity.Property(e => e.Lips).HasMaxLength(50);

                entity.Property(e => e.LipsDescrib).HasMaxLength(250);

                entity.Property(e => e.MovBackTongue).HasMaxLength(150);

                entity.Property(e => e.MovementLips).HasMaxLength(150);

                entity.Property(e => e.MovementSoft).HasMaxLength(150);

                entity.Property(e => e.MovementVelar).HasMaxLength(150);

                entity.Property(e => e.NasalCavity).HasMaxLength(50);

                entity.Property(e => e.NasalCavityDescrib).HasMaxLength(250);

                entity.Property(e => e.Palate)
                    .HasMaxLength(150)
                    .HasColumnName("palate");

                entity.Property(e => e.SoftPalateDescrib).HasMaxLength(250);

                entity.Property(e => e.Softpalate).HasMaxLength(50);

                entity.Property(e => e.Teeth).HasMaxLength(50);

                entity.Property(e => e.TeethDescrib).HasMaxLength(250);

                entity.Property(e => e.Tongue).HasMaxLength(50);

                entity.Property(e => e.TongueDescrib).HasMaxLength(250);

                entity.Property(e => e.Tonsils).HasMaxLength(50);

                entity.Property(e => e.TonsilsDescrib).HasMaxLength(250);

                entity.Property(e => e.Velar).HasMaxLength(50);

                entity.Property(e => e.VelarDescrib).HasMaxLength(250);

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.PronAssessmentOrofacialExams)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessmentOrofacialExam_PronAssessment");
            });

            modelBuilder.Entity<PronAssessmentSoundLetter>(entity =>
            {
                entity.HasKey(e => e.AssessmentSoundId);

                entity.ToTable("PronAssessmentSoundLetter");

                entity.Property(e => e.AssessmentSoundId).HasColumnName("AssessmentSoundID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.IsEndWord).HasColumnName("IS_EndWord");

                entity.Property(e => e.IsFirstWord).HasColumnName("IS_FirstWord");

                entity.Property(e => e.IsMidWord).HasColumnName("IS_MidWord");

                entity.Property(e => e.IsSection).HasColumnName("IS_Section");

                entity.Property(e => e.IsSingle).HasColumnName("IS_Single");

                entity.Property(e => e.SoundLetterId).HasColumnName("SoundLetterID");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.PronAssessmentSoundLetters)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessmentSoundLetter_PronAssessment");

                entity.HasOne(d => d.SoundLetter)
                    .WithMany(p => p.PronAssessmentSoundLetters)
                    .HasForeignKey(d => d.SoundLetterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessmentSoundLetter_PronSoundLetter");
            });

            modelBuilder.Entity<PronAssessmnetVocab>(entity =>
            {
                entity.HasKey(e => e.AssessmnetVocabId);

                entity.ToTable("PronAssessmnetVocab");

                entity.Property(e => e.AssessmnetVocabId).HasColumnName("AssessmnetVocabID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.IsExpress).HasColumnName("IS_Express");

                entity.Property(e => e.IsGesture).HasColumnName("IS_Gesture");

                entity.Property(e => e.IsUnderstand).HasColumnName("IS_Understand");

                entity.Property(e => e.VocabId).HasColumnName("VocabID");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.PronAssessmnetVocabs)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessmnetVocab_PronAssessment");

                entity.HasOne(d => d.Vocab)
                    .WithMany(p => p.PronAssessmnetVocabs)
                    .HasForeignKey(d => d.VocabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronAssessmnetVocab_PronVocab");
            });

            modelBuilder.Entity<PronInstruction>(entity =>
            {
                entity.HasKey(e => e.InstructionId);

                entity.ToTable("PronInstruction");

                entity.Property(e => e.InstructionId).HasColumnName("InstructionID");

                entity.Property(e => e.Instruction)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PronLongTarget>(entity =>
            {
                entity.HasKey(e => e.LongTargetId);

                entity.ToTable("PronLongTarget");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<PronMedicalCase>(entity =>
            {
                entity.HasKey(e => e.MedicalCaseId);

                entity.ToTable("PronMedicalCase");

                entity.Property(e => e.MedicalCaseId).HasColumnName("MedicalCaseID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.BreathingProblems).HasMaxLength(50);

                entity.Property(e => e.BreathingProblemsDescrib).HasMaxLength(150);

                entity.Property(e => e.CircumstanceBirth).HasMaxLength(50);

                entity.Property(e => e.Cognitive).HasMaxLength(50);

                entity.Property(e => e.CognitiveDescrib).HasMaxLength(150);

                entity.Property(e => e.CrampsEpilepsy).HasMaxLength(50);

                entity.Property(e => e.CrampsEpilepsyDescrib).HasMaxLength(50);

                entity.Property(e => e.Crawling).HasMaxLength(50);

                entity.Property(e => e.CrawlingDescrib).HasMaxLength(50);

                entity.Property(e => e.DescribedMotoProb).HasMaxLength(350);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.DescriptionIssueStatus).HasMaxLength(350);

                entity.Property(e => e.FamilyMemhasdiagnosis)
                    .HasMaxLength(50)
                    .HasColumnName("familyMemhasdiagnosis");

                entity.Property(e => e.FamilyMemhasdiagnosisDescrib)
                    .HasMaxLength(150)
                    .HasColumnName("familyMemhasdiagnosisDescrib");

                entity.Property(e => e.Hearing).HasMaxLength(50);

                entity.Property(e => e.HearingDescrib).HasMaxLength(150);

                entity.Property(e => e.HowGuardians).HasMaxLength(350);

                entity.Property(e => e.HowProblemStarted).HasMaxLength(350);

                entity.Property(e => e.Motor).HasMaxLength(20);

                entity.Property(e => e.NoteMotor).HasMaxLength(450);

                entity.Property(e => e.RunnySaliva).HasMaxLength(50);

                entity.Property(e => e.RunnySalivaDescrib).HasMaxLength(150);

                entity.Property(e => e.Sitting).HasMaxLength(50);

                entity.Property(e => e.SittingDescrib).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Surgery)
                    .HasMaxLength(50)
                    .HasColumnName("surgery");

                entity.Property(e => e.SurgeryDescrib)
                    .HasMaxLength(150)
                    .HasColumnName("surgeryDescrib");

                entity.Property(e => e.SwallowingProb).HasMaxLength(50);

                entity.Property(e => e.SwallowingProbDescrib)
                    .HasMaxLength(150)
                    .HasComment("مشاكل فى البلع");

                entity.Property(e => e.TakeMedicine).HasMaxLength(50);

                entity.Property(e => e.TakeMedicineDescrib).HasMaxLength(150);

                entity.Property(e => e.TakeSpecMedicine).HasMaxLength(50);

                entity.Property(e => e.TakeSpecMedicineDescrib).HasMaxLength(150);

                entity.Property(e => e.Visual).HasMaxLength(50);

                entity.Property(e => e.VisualDescrib).HasMaxLength(150);

                entity.Property(e => e.Walking).HasMaxLength(50);

                entity.Property(e => e.WalkingDescrib).HasMaxLength(50);

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.PronMedicalCases)
                    .HasForeignKey(d => d.AssessmentId)
                    .HasConstraintName("FK_PronMedicalCase_PronAssessment");
            });

            modelBuilder.Entity<PronMoveCategory>(entity =>
            {
                entity.HasKey(e => e.MoveCategoryId);

                entity.ToTable("PronMoveCategory");

                entity.Property(e => e.MoveCategoryId).HasColumnName("MoveCategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PronMovement>(entity =>
            {
                entity.HasKey(e => e.MovementId);

                entity.ToTable("PronMovement");

                entity.Property(e => e.MovementId).HasColumnName("MovementID");

                entity.Property(e => e.MoveCategoryId).HasColumnName("MoveCategoryID");

                entity.Property(e => e.Movement)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.MoveCategory)
                    .WithMany(p => p.PronMovements)
                    .HasForeignKey(d => d.MoveCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronMovement_PronMoveCategory");
            });

            modelBuilder.Entity<PronPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("PronPlan");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Diagnosis).HasMaxLength(550);

                entity.Property(e => e.Recomendation).HasMaxLength(350);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<PronPlanTarget>(entity =>
            {
                entity.HasKey(e => e.PlanTargetId);

                entity.ToTable("PronPlanTarget");

                entity.Property(e => e.PlanTargetId).HasColumnName("PlanTargetID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.LongTarget)
                    .WithMany(p => p.PronPlanTargets)
                    .HasForeignKey(d => d.LongTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronPlanTarget_PronLongTarget");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PronPlanTargets)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronPlanTarget_PronPlan");
            });

            modelBuilder.Entity<PronReportStudent>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("PronReportStudent");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.PlanName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PronReportStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronReportStudent_Student");
            });

            modelBuilder.Entity<PronSocailHistoryCase>(entity =>
            {
                entity.HasKey(e => e.SocailHisId);

                entity.ToTable("PronSocailHistoryCase");

                entity.Property(e => e.SocailHisId).HasColumnName("SocailHisID");

                entity.Property(e => e.ArrangeChild).HasMaxLength(50);

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.ChildLive).HasMaxLength(50);

                entity.Property(e => e.CommunicationDisorder).HasMaxLength(500);

                entity.Property(e => e.RelationBparent)
                    .HasMaxLength(50)
                    .HasColumnName("RelationBParent");

                entity.Property(e => e.SocialStatusParents)
                    .HasMaxLength(50)
                    .HasColumnName("socialStatusParents");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.PronSocailHistoryCases)
                    .HasForeignKey(d => d.AssessmentId)
                    .HasConstraintName("FK_PronSocailHistoryCase_PronAssessment");
            });

            modelBuilder.Entity<PronSoundLetter>(entity =>
            {
                entity.HasKey(e => e.SoundLetterId);

                entity.ToTable("PronSoundLetter");

                entity.Property(e => e.SoundLetterId).HasColumnName("SoundLetterID");

                entity.Property(e => e.LetterName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PronTargetGoal>(entity =>
            {
                entity.HasKey(e => e.TargetGoalId);

                entity.ToTable("PronTargetGoal");

                entity.Property(e => e.TargetGoalId).HasColumnName("TargetGoalID");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.GoalId).HasColumnName("GoalID");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PlanTargetId).HasColumnName("PlanTargetID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.Achievement)
                    .WithMany(p => p.PronTargetGoals)
                    .HasForeignKey(d => d.AchievementId)
                    .HasConstraintName("FK_PronTargetGoal_PronAchievement");

                entity.HasOne(d => d.Goal)
                    .WithMany(p => p.PronTargetGoals)
                    .HasForeignKey(d => d.GoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronTargetGoal_PronTherapeuticGoal");

                entity.HasOne(d => d.PlanTarget)
                    .WithMany(p => p.PronTargetGoals)
                    .HasForeignKey(d => d.PlanTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronTargetGoal_PronPlanTarget");
            });

            modelBuilder.Entity<PronTherapeuticGoal>(entity =>
            {
                entity.HasKey(e => e.GoalId);

                entity.ToTable("PronTherapeuticGoal");

                entity.Property(e => e.GoalId).HasColumnName("GoalID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Goals)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<PronVocab>(entity =>
            {
                entity.HasKey(e => e.VocabId);

                entity.ToTable("PronVocab");

                entity.Property(e => e.VocabId).HasColumnName("VocabID");

                entity.Property(e => e.VocabCategoryId).HasColumnName("VocabCategoryID");

                entity.Property(e => e.Vocabularies)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.VocabCategory)
                    .WithMany(p => p.PronVocabs)
                    .HasForeignKey(d => d.VocabCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PronVocab_PronVocabCategory");
            });

            modelBuilder.Entity<PronVocabCategory>(entity =>
            {
                entity.HasKey(e => e.VocabCategoryId);

                entity.ToTable("PronVocabCategory");

                entity.Property(e => e.VocabCategoryId).HasColumnName("VocabCategoryID");

                entity.Property(e => e.VocabCategory)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PsyBehavAnalysisItem>(entity =>
            {
                entity.HasKey(e => e.BehavAnalysisItemId);

                entity.ToTable("PsyBehavAnalysisItem");

                entity.Property(e => e.BehavAnalysisItemId)
                    .HasColumnName("BehavAnalysisItemID")
                    .HasComment("مسلسل بنود تحليل السلوك");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("اسم البند لتحليل السلوك");

                entity.Property(e => e.Parent).HasComment("اب مسلسل تحليل السلوك");

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.InverseParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .HasConstraintName("FK_PsyBehavAnalysisItem_PsyBehavAnalysisItem");
            });

            modelBuilder.Entity<PsyBehaviorForm>(entity =>
            {
                entity.HasKey(e => e.BehaviorFormId);

                entity.ToTable("PsyBehaviorForm");

                entity.Property(e => e.BehaviorFormId)
                    .HasColumnName("behaviorFormID")
                    .HasComment("مسلسل استارة رصد السلوك");

                entity.Property(e => e.ActionTake)
                    .HasMaxLength(500)
                    .HasComment("ما هو التصرف الذي يتم في مقابل السلوك؟");

                entity.Property(e => e.AfterBehavior)
                    .HasMaxLength(500)
                    .HasComment("ما الذي يحدث بعد السلوك؟");

                entity.Property(e => e.BeforeBehavior)
                    .HasMaxLength(500)
                    .HasComment("ما الذي يحدث قبل السلوك؟");

                entity.Property(e => e.BehaviorNedModify)
                    .HasMaxLength(500)
                    .HasColumnName("behaviorNedModify")
                    .HasComment("السلوك المراد تعديله ");

                entity.Property(e => e.BehaviorOccur)
                    .HasMaxLength(500)
                    .HasComment("متي يحدث السلوك؟ في أي موقف يحدث السلوك");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateSuggesFrom)
                    .HasColumnType("smalldatetime")
                    .HasComment("الوقت المقترح من");

                entity.Property(e => e.DateSuggesTo)
                    .HasColumnType("smalldatetime")
                    .HasComment("الوقت المقترح الى");

                entity.Property(e => e.DescBehavior)
                    .HasMaxLength(500)
                    .HasComment("التعريف الإجرائي للسلوك ");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SourceInfo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مصدر المعلومات");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasComment("مسلسل الطالب");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(100)
                    .HasComment("المشرف");

                entity.Property(e => e.Teacher)
                    .HasMaxLength(100)
                    .HasComment("المدرس");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PsyBehaviorForms)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyBehaviorForm_Student");
            });

            modelBuilder.Entity<PsyBehaviorFormMonitor>(entity =>
            {
                entity.HasKey(e => e.BehaviorMonitorId);

                entity.ToTable("PsyBehaviorFormMonitor");

                entity.Property(e => e.BehaviorMonitorId)
                    .HasColumnName("behaviorMonitorID")
                    .HasComment("مسلسل رصد الاستمارة");

                entity.Property(e => e.BehaviorFormId)
                    .HasColumnName("behaviorFormID")
                    .HasComment("مسلسل الاستمارة");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateMonitor)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ الرصد");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .HasComment("مكان الرصد");

                entity.Property(e => e.PeriodNotes)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("مدة الملاحظة");

                entity.Property(e => e.RepeatNo)
                    .HasColumnName("RepeatNO")
                    .HasComment("عدد التكرار");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.BehaviorForm)
                    .WithMany(p => p.PsyBehaviorFormMonitors)
                    .HasForeignKey(d => d.BehaviorFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyBehaviorFormMonitor_PsyBehaviorForm");
            });

            modelBuilder.Entity<PsyCaseStudy>(entity =>
            {
                entity.HasKey(e => e.CaseStudyId);

                entity.ToTable("PsyCaseStudy");

                entity.Property(e => e.CaseStudyId).HasColumnName("CaseStudyID");

                entity.Property(e => e.Answer).IsRequired();

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PsyCaseStudies)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyCaseStudy_PsyQuestion");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PsyCaseStudies)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_PsyCaseStudy_Student");
            });

            modelBuilder.Entity<PsyEncourageType>(entity =>
            {
                entity.HasKey(e => e.EncourageTypeId);

                entity.ToTable("PsyEncourageType");

                entity.Property(e => e.EncourageTypeId).HasColumnName("EncourageTypeID");

                entity.Property(e => e.EncourageName).HasMaxLength(150);
            });

            modelBuilder.Entity<PsyPlanModiBehavMonitor>(entity =>
            {
                entity.HasKey(e => e.PmbehaviorMonitorId);

                entity.ToTable("PsyPlanModiBehavMonitor");

                entity.Property(e => e.PmbehaviorMonitorId).HasColumnName("PMBehaviorMonitorID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateMonitor)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ الرصد");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .HasComment("مكان الرصد");

                entity.Property(e => e.PeriodNotes)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("مدة الملاحظة");

                entity.Property(e => e.PlanBehaviorId)
                    .HasColumnName("PlanBehaviorID")
                    .HasComment("مسلسل خطة تعديل السلوك");

                entity.Property(e => e.RepeatNo)
                    .HasColumnName("RepeatNO")
                    .HasComment("عدد التكرار");

                entity.Property(e => e.TypeMonitor).HasComment(" 0- اثناء تطبيق الخطة\r\n1- بعد توقف الخطة");

                entity.HasOne(d => d.PlanBehavior)
                    .WithMany(p => p.PsyPlanModiBehavMonitors)
                    .HasForeignKey(d => d.PlanBehaviorId)
                    .HasConstraintName("FK_PsyPlanModiBehavMonitor_PsyPlanModifiBehavior");
            });

            modelBuilder.Entity<PsyPlanModifiBehavMethEncrage>(entity =>
            {
                entity.HasKey(e => e.MethodEncourageId);

                entity.ToTable("PsyPlanModifiBehavMethEncrage");

                entity.Property(e => e.MethodEncourageId).HasColumnName("MethodEncourageID");

                entity.Property(e => e.BehavAnalysisItemId).HasColumnName("BehavAnalysisItemID");

                entity.Property(e => e.EncourageMethod)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EncourageTypeId).HasColumnName("EncourageTypeID");

                entity.Property(e => e.PlanBehaviorId).HasColumnName("PlanBehaviorID");

                entity.HasOne(d => d.BehavAnalysisItem)
                    .WithMany(p => p.PsyPlanModifiBehavMethEncrages)
                    .HasForeignKey(d => d.BehavAnalysisItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyPlanModifiBehavMethEncrage_PsyPlanModifiBehavMethEncrage");

                entity.HasOne(d => d.EncourageType)
                    .WithMany(p => p.PsyPlanModifiBehavMethEncrages)
                    .HasForeignKey(d => d.EncourageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyPlanModifiBehavMethEncrage_PsyEncourageType");

                entity.HasOne(d => d.PlanBehavior)
                    .WithMany(p => p.PsyPlanModifiBehavMethEncrages)
                    .HasForeignKey(d => d.PlanBehaviorId)
                    .HasConstraintName("FK_PsyPlanModifiBehavMethEncrage_PsyPlanModifiBehavior");
            });

            modelBuilder.Entity<PsyPlanModifiBehavMethod>(entity =>
            {
                entity.HasKey(e => e.PlanMethodId);

                entity.ToTable("PsyPlanModifiBehavMethod");

                entity.Property(e => e.PlanMethodId)
                    .HasColumnName("PlanMethodID")
                    .HasComment("مسلسل طرق خطة تعديل السلوك");

                entity.Property(e => e.BehavAnalysisItemId)
                    .HasColumnName("BehavAnalysisItemID")
                    .HasComment("مسلسل بنود تحليل السلوك");

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(350)
                    .HasComment("شرح طريقة تحليل السلوك");

                entity.Property(e => e.PlanBehaviorId)
                    .HasColumnName("PlanBehaviorID")
                    .HasComment("مسلسل خطة تعديل السلوك");

                entity.HasOne(d => d.BehavAnalysisItem)
                    .WithMany(p => p.PsyPlanModifiBehavMethods)
                    .HasForeignKey(d => d.BehavAnalysisItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyPlanModifiBehavMethod_PsyBehavAnalysisItem");

                entity.HasOne(d => d.PlanBehavior)
                    .WithMany(p => p.PsyPlanModifiBehavMethods)
                    .HasForeignKey(d => d.PlanBehaviorId)
                    .HasConstraintName("FK_PsyPlanModifiBehavMethod_PsyPlanModifiBehavior");
            });

            modelBuilder.Entity<PsyPlanModifiBehavior>(entity =>
            {
                entity.HasKey(e => e.PlanBehaviorId)
                    .HasName("PK_PsyPlanBehavior");

                entity.ToTable("PsyPlanModifiBehavior");

                entity.Property(e => e.PlanBehaviorId)
                    .HasColumnName("PlanBehaviorID")
                    .HasComment("مسلسل تعديل السلوك");

                entity.Property(e => e.BehaviorFormId)
                    .HasColumnName("behaviorFormID")
                    .HasComment("مسلسل استمارة تعديل السلوك");

                entity.Property(e => e.Examineby)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("examineby")
                    .HasComment("اسم الفاحص");

                entity.Property(e => e.PostDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TargetPlane)
                    .IsRequired()
                    .HasMaxLength(350)
                    .HasComment("الهدف من خطة تعديل السلوك");

                entity.HasOne(d => d.BehaviorForm)
                    .WithMany(p => p.PsyPlanModifiBehaviors)
                    .HasForeignKey(d => d.BehaviorFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyPlanModifiBehavior_PsyBehaviorForm");
            });

            modelBuilder.Entity<PsyProblem>(entity =>
            {
                entity.HasKey(e => e.ProblemId);

                entity.ToTable("PsyProblem");

                entity.Property(e => e.ProblemId)
                    .HasColumnName("ProblemID")
                    .HasComment("مسلسل المشكلة");

                entity.Property(e => e.ProblemGroupId)
                    .HasColumnName("ProblemGroupID")
                    .HasComment("مسلسل مجموعة حصر المشكلة");

                entity.Property(e => e.ProblemName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("المشكلة");

                entity.HasOne(d => d.ProblemGroup)
                    .WithMany(p => p.PsyProblems)
                    .HasForeignKey(d => d.ProblemGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyProblem_PsyProblemGroup");
            });

            modelBuilder.Entity<PsyProblemGroup>(entity =>
            {
                entity.HasKey(e => e.ProblemGroupId);

                entity.ToTable("PsyProblemGroup");

                entity.Property(e => e.ProblemGroupId)
                    .HasColumnName("ProblemGroupID")
                    .HasComment("مسلسل مجموعات المشاكل");

                entity.Property(e => e.ProbGroupName).HasMaxLength(250);
            });

            modelBuilder.Entity<PsyProblemStudent>(entity =>
            {
                entity.HasKey(e => e.ProblemStudentId)
                    .HasName("PK_PsyProblemStudent_1");

                entity.ToTable("PsyProblemStudent");

                entity.Property(e => e.ProblemStudentId).HasColumnName("ProblemStudentID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.NoteAfterStimuli)
                    .HasMaxLength(450)
                    .HasComment("*المثيرات  البعديه");

                entity.Property(e => e.NoteDefineCaseProb)
                    .HasMaxLength(450)
                    .HasComment("*االتعريف الإجرائي للسلوك");

                entity.Property(e => e.NoteEpisodic)
                    .HasMaxLength(450)
                    .HasComment("التعريف العرضى للحالة");

                entity.Property(e => e.NoteRedFlag)
                    .HasMaxLength(450)
                    .HasComment("*the red flag (منذر حدوث السلوك)");

                entity.Property(e => e.NoteTribal)
                    .HasMaxLength(50)
                    .HasComment("*المثيرات القبليه");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PsyProblemStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyProblemStudent_Student1");
            });

            modelBuilder.Entity<PsyProblemStudent1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PsyProblemStudents");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.ProblemId).HasColumnName("ProblemID");

                entity.Property(e => e.ProblemStudentId).HasColumnName("ProblemStudentID");

                entity.Property(e => e.ProblemStudentRespId).HasColumnName("ProblemStudentRespID");
            });

            modelBuilder.Entity<PsyProblemStudentResponse>(entity =>
            {
                entity.HasKey(e => e.ProblemStudentRespId)
                    .HasName("PK_PsyProblemStudent");

                entity.ToTable("PsyProblemStudentResponse");

                entity.Property(e => e.ProblemStudentRespId)
                    .HasColumnName("ProblemStudentRespID")
                    .HasComment("مسلسل حصر المشكلة للطالب");

                entity.Property(e => e.ProblemId)
                    .HasColumnName("ProblemID")
                    .HasComment("مسلسل المشكلة");

                entity.Property(e => e.ProblemStudentId)
                    .HasColumnName("ProblemStudentID")
                    .HasComment("مسلسل الطالب");

                entity.Property(e => e.Result).HasComment("النتيجة\r\n0- لا يوجد للطالبهذه المشكلة\r\n1- الطالب لدية هذه المشكلة");

                entity.HasOne(d => d.Problem)
                    .WithMany(p => p.PsyProblemStudentResponses)
                    .HasForeignKey(d => d.ProblemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyProblemStudent_PsyProblem");

                entity.HasOne(d => d.ProblemStudent)
                    .WithMany(p => p.PsyProblemStudentResponses)
                    .HasForeignKey(d => d.ProblemStudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PsyProblemStudent_Student");
            });

            modelBuilder.Entity<PsyQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("PsyQuestion");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("اسئلة دراسة الحالة");
            });

            modelBuilder.Entity<ResidAbsenceStudent>(entity =>
            {
                entity.HasKey(e => e.AbsenceStudentId);

                entity.ToTable("ResidAbsenceStudent");

                entity.Property(e => e.AbsenceStudentId).HasColumnName("AbsenceStudentID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ResidAbsenceStudents)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidAbsenceStudent_ResidAbsenceStudent");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ResidAbsenceStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidAbsenceStudent_Student");
            });

            modelBuilder.Entity<ResidAsset>(entity =>
            {
                entity.HasKey(e => e.AssetId);

                entity.ToTable("ResidAsset");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.AssetName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(150);
            });

            modelBuilder.Entity<ResidAssetRom>(entity =>
            {
                entity.HasKey(e => e.AssetRomId);

                entity.ToTable("ResidAssetRom");

                entity.Property(e => e.AssetRomId).HasColumnName("AssetRomID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.ResidAssetRoms)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidAssetRom_ResidAsset");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ResidAssetRoms)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidAssetRom_ResidRoom");
            });

            modelBuilder.Entity<ResidComunType>(entity =>
            {
                entity.HasKey(e => e.ComunTypeId);

                entity.ToTable("ResidComunType");

                entity.Property(e => e.ComunTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ComunTypeID");

                entity.Property(e => e.ComunType)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<ResidFinalReport>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("ResidFinalReport");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DegreActivity).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(550);

                entity.Property(e => e.IsBehavHarmAsset).HasColumnName("IS_BehavHarmAsset");

                entity.Property(e => e.IsBehavHarmBody).HasColumnName("IS_BehavHarmBody");

                entity.Property(e => e.IsBehavToOther).HasColumnName("IS_BehavToOther");

                entity.Property(e => e.IsBehavToSelf).HasColumnName("IS_BehavToSelf");

                entity.Property(e => e.IsEasttingFood)
                    .HasMaxLength(50)
                    .HasColumnName("IS_EasttingFood");

                entity.Property(e => e.IsUseBathRoom)
                    .HasMaxLength(50)
                    .HasColumnName("Is_UseBathRoom");

                entity.Property(e => e.IsWearShose)
                    .HasMaxLength(50)
                    .HasColumnName("IS_WearShose");

                entity.Property(e => e.IsWearing)
                    .HasMaxLength(50)
                    .HasColumnName("IS_wearing");

                entity.Property(e => e.NoteActivity).HasMaxLength(350);

                entity.Property(e => e.NoteBehavPattern).HasMaxLength(450);

                entity.Property(e => e.NotesSkill).HasMaxLength(550);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ResidFinalReports)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidFinalReport_Student");
            });

            modelBuilder.Entity<ResidNoteCaregiver>(entity =>
            {
                entity.HasKey(e => e.NoteCaregiverId);

                entity.ToTable("ResidNoteCaregiver");

                entity.Property(e => e.NoteCaregiverId).HasColumnName("NoteCaregiverID");

                entity.Property(e => e.CaregiverId).HasColumnName("caregiverID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(450);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TypeNote).HasMaxLength(50);

                entity.HasOne(d => d.Caregiver)
                    .WithMany(p => p.ResidNoteCaregivers)
                    .HasForeignKey(d => d.CaregiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidNoteCaregiver_HrEmployee");
            });

            modelBuilder.Entity<ResidNoteComunity>(entity =>
            {
                entity.HasKey(e => e.ComunNoteId);

                entity.ToTable("ResidNoteComunity");

                entity.Property(e => e.ComunNoteId).HasColumnName("ComunNoteID");

                entity.Property(e => e.ComunTypeId).HasColumnName("ComunTypeID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.ComunType)
                    .WithMany(p => p.ResidNoteComunities)
                    .HasForeignKey(d => d.ComunTypeId)
                    .HasConstraintName("FK_ResidNoteComunity_ResidComunType");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ResidNoteComunities)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidNoteComunity_Student");
            });

            modelBuilder.Entity<ResidNoteDaily>(entity =>
            {
                entity.HasKey(e => e.DailyNoteId);

                entity.ToTable("ResidNoteDaily");

                entity.Property(e => e.DailyNoteId).HasColumnName("DailyNoteID");

                entity.Property(e => e.CaregiverId).HasColumnName("caregiverID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.NoteTypeId).HasColumnName("NoteTypeID");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Time).HasColumnName("time");

                entity.HasOne(d => d.Caregiver)
                    .WithMany(p => p.ResidNoteDailies)
                    .HasForeignKey(d => d.CaregiverId)
                    .HasConstraintName("FK_ResidNoteDaily_HrEmployee");

                entity.HasOne(d => d.NoteType)
                    .WithMany(p => p.ResidNoteDailies)
                    .HasForeignKey(d => d.NoteTypeId)
                    .HasConstraintName("FK_ResidNoteDaily_ResidNoteType");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ResidNoteDailies)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_ResidNoteDaily_ResidRoom");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ResidNoteDailies)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidNoteDaily_ResidSection");
            });

            modelBuilder.Entity<ResidNoteDailyStudent>(entity =>
            {
                entity.HasKey(e => e.StudentNoteId);

                entity.ToTable("ResidNoteDailyStudent");

                entity.Property(e => e.StudentNoteId).HasColumnName("StudentNoteID");

                entity.Property(e => e.DailyNoteId).HasColumnName("DailyNoteID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.DailyNote)
                    .WithMany(p => p.ResidNoteDailyStudents)
                    .HasForeignKey(d => d.DailyNoteId)
                    .HasConstraintName("FK_ResidNoteDailyStudent_ResidNoteDaily");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ResidNoteDailyStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidNoteDailyStudent_Student");
            });

            modelBuilder.Entity<ResidNoteRom>(entity =>
            {
                entity.HasKey(e => e.NoteRomId);

                entity.ToTable("ResidNoteRom");

                entity.Property(e => e.NoteRomId).HasColumnName("NoteRomID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.ProcesType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.ResidNoteRoms)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidNoteRom_ResidAsset");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ResidNoteRoms)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidNoteRom_ResidRoom");
            });

            modelBuilder.Entity<ResidNoteType>(entity =>
            {
                entity.HasKey(e => e.NoteTypeId);

                entity.ToTable("ResidNoteType");

                entity.Property(e => e.NoteTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NoteTypeID");

                entity.Property(e => e.NoteType).HasMaxLength(50);
            });

            modelBuilder.Entity<ResidOutPermssion>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.ToTable("ResidOutPermssion");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.ActualReturnDate).HasColumnType("date");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateLeave).HasColumnType("date");

                entity.Property(e => e.DateReturn).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.NoteParent).HasMaxLength(250);

                entity.Property(e => e.NoteSupervisour).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ResidOutPermssions)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_ResidOutPermssion_Student");
            });

            modelBuilder.Entity<ResidOutPermssionAttach>(entity =>
            {
                entity.HasKey(e => e.OutPermiAttachId);

                entity.ToTable("ResidOutPermssionAttach");

                entity.Property(e => e.OutPermiAttachId).HasColumnName("OutPermiAttachID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.IsOut).HasColumnName("IS_out");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.PersAttachId).HasColumnName("PersAttachID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.ResidOutPermssionAttaches)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidOutPermssionAttach_ResidOutPermssion");

                entity.HasOne(d => d.PersAttach)
                    .WithMany(p => p.ResidOutPermssionAttaches)
                    .HasForeignKey(d => d.PersAttachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidOutPermssionAttach_ResidPersonalAttach");
            });

            modelBuilder.Entity<ResidPersonalAttach>(entity =>
            {
                entity.HasKey(e => e.PersAttachId);

                entity.ToTable("ResidPersonalAttach");

                entity.Property(e => e.PersAttachId).HasColumnName("PersAttachID");

                entity.Property(e => e.AttachName)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsOut).HasColumnName("IS_out");

                entity.Property(e => e.LdateIn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LDateIn");

                entity.Property(e => e.LdateOut).HasColumnType("smalldatetime");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ResidPersonalAttaches)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidPersonalAttach_Student");
            });

            modelBuilder.Entity<ResidRepAssociatBehav>(entity =>
            {
                entity.HasKey(e => e.AssociatedBehavId);

                entity.ToTable("ResidRepAssociatBehav");

                entity.Property(e => e.AssociatedBehavId).HasColumnName("AssociatedBehavID");

                entity.Property(e => e.AssociatedBehav)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<ResidRepBehavPattern>(entity =>
            {
                entity.HasKey(e => e.BehavPatternId);

                entity.ToTable("ResidRepBehavPattern");

                entity.Property(e => e.BehavPatternId).HasColumnName("BehavPatternID");

                entity.Property(e => e.BehavPattern)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<ResidRepContParent>(entity =>
            {
                entity.HasKey(e => e.ContactParentId);

                entity.ToTable("ResidRepContParent");

                entity.Property(e => e.ContactParentId).HasColumnName("ContactParentID");

                entity.Property(e => e.ContactParent)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<ResidRepExcelenActivity>(entity =>
            {
                entity.HasKey(e => e.ExcelenActivityId);

                entity.ToTable("ResidRepExcelenActivity");

                entity.Property(e => e.ExcelenActivityId).HasColumnName("ExcelenActivityID");

                entity.Property(e => e.ExcelenActivity)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<ResidRepFavActivity>(entity =>
            {
                entity.HasKey(e => e.FavActivityId);

                entity.ToTable("ResidRepFavActivity");

                entity.Property(e => e.FavActivityId).HasColumnName("FavActivityID");

                entity.Property(e => e.FavActivity)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ResidRepRecomendSuper>(entity =>
            {
                entity.HasKey(e => e.RecomendSuperId);

                entity.ToTable("ResidRepRecomendSuper");

                entity.Property(e => e.RecomendSuperId).HasColumnName("RecomendSuperID");

                entity.Property(e => e.Recomendation)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<ResidReportAssociBehav>(entity =>
            {
                entity.HasKey(e => e.ReportAssociBehavId);

                entity.ToTable("ResidReportAssociBehav");

                entity.Property(e => e.ReportAssociBehavId).HasColumnName("ReportAssociBehavID");

                entity.Property(e => e.AssociatedBehavId).HasColumnName("AssociatedBehavID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.AssociatedBehav)
                    .WithMany(p => p.ResidReportAssociBehavs)
                    .HasForeignKey(d => d.AssociatedBehavId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportAssociBehav_ResidRepAssociatBehav");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ResidReportAssociBehavs)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportAssociBehav_ResidFinalReport");
            });

            modelBuilder.Entity<ResidReportBehavPattern>(entity =>
            {
                entity.HasKey(e => e.ReportBehavPatternId);

                entity.ToTable("ResidReportBehavPattern");

                entity.Property(e => e.ReportBehavPatternId).HasColumnName("ReportBehavPatternID");

                entity.Property(e => e.BehavPatternId).HasColumnName("BehavPatternID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.BehavPattern)
                    .WithMany(p => p.ResidReportBehavPatterns)
                    .HasForeignKey(d => d.BehavPatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportBehavPattern_ResidRepBehavPattern");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ResidReportBehavPatterns)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportBehavPattern_ResidFinalReport");
            });

            modelBuilder.Entity<ResidReportContParent>(entity =>
            {
                entity.HasKey(e => e.ReportContParentId);

                entity.ToTable("ResidReportContParent");

                entity.Property(e => e.ReportContParentId).HasColumnName("ReportContParentID");

                entity.Property(e => e.ContactParentId).HasColumnName("ContactParentID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.ContactParent)
                    .WithMany(p => p.ResidReportContParents)
                    .HasForeignKey(d => d.ContactParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportContParent_ResidRepContParent");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ResidReportContParents)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportContParent_ResidFinalReport");
            });

            modelBuilder.Entity<ResidReportExcelenActiv>(entity =>
            {
                entity.HasKey(e => e.ReportExcelenActId);

                entity.ToTable("ResidReportExcelenActiv");

                entity.Property(e => e.ReportExcelenActId).HasColumnName("ReportExcelenActID");

                entity.Property(e => e.ExcelenActivityId).HasColumnName("ExcelenActivityID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.ExcelenActivity)
                    .WithMany(p => p.ResidReportExcelenActivs)
                    .HasForeignKey(d => d.ExcelenActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportExcelenActiv_ResidRepExcelenActivity");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ResidReportExcelenActivs)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportExcelenActiv_ResidFinalReport");
            });

            modelBuilder.Entity<ResidReportFavActivity>(entity =>
            {
                entity.HasKey(e => e.ReportFavActivityId);

                entity.ToTable("ResidReportFavActivity");

                entity.Property(e => e.ReportFavActivityId).HasColumnName("ReportFavActivityID");

                entity.Property(e => e.FavActivityId).HasColumnName("FavActivityID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.FavActivity)
                    .WithMany(p => p.ResidReportFavActivities)
                    .HasForeignKey(d => d.FavActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportFavActivity_ResidRepFavActivity");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ResidReportFavActivities)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportFavActivity_ResidFinalReport");
            });

            modelBuilder.Entity<ResidReportRecomSuper>(entity =>
            {
                entity.HasKey(e => e.ReportRecomSuperId);

                entity.ToTable("ResidReportRecomSuper");

                entity.Property(e => e.ReportRecomSuperId).HasColumnName("ReportRecomSuperID");

                entity.Property(e => e.RecomendSuperId).HasColumnName("RecomendSuperID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.RecomendSuper)
                    .WithMany(p => p.ResidReportRecomSupers)
                    .HasForeignKey(d => d.RecomendSuperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportRecomSuper_ResidRepRecomendSuper");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ResidReportRecomSupers)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidReportRecomSuper_ResidFinalReport");
            });

            modelBuilder.Entity<ResidRoom>(entity =>
            {
                entity.HasKey(e => e.RoomId);

                entity.ToTable("ResidRoom");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.CareGiverId).HasColumnName("CareGiverID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ResidRooms)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidRoom_ResidSection");
            });

            modelBuilder.Entity<ResidSection>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("ResidSection");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SuperVisouerId).HasColumnName("SuperVisouerID");
            });

            modelBuilder.Entity<ResidStudRoom>(entity =>
            {
                entity.HasKey(e => e.StudRoomId);

                entity.ToTable("ResidStudRoom");

                entity.Property(e => e.StudRoomId).HasColumnName("StudRoomID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ResidStudRooms)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidStudRoom_ResidRoom");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ResidStudRooms)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidStudRoom_Student");
            });

            modelBuilder.Entity<ResidTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("ResidTask");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TaskTypeId).HasColumnName("TaskTypeID");

                entity.Property(e => e.Taskname)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.ResidTasks)
                    .HasForeignKey(d => d.TaskTypeId)
                    .HasConstraintName("FK_ResidTask_ResidTaskType");
            });

            modelBuilder.Entity<ResidTaskDate>(entity =>
            {
                entity.HasKey(e => e.TaskDateId);

                entity.ToTable("ResidTaskDate");

                entity.Property(e => e.TaskDateId).HasColumnName("TaskDateID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ResidTaskDates)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidTaskDate_ResidSection");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ResidTaskDates)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResidTaskDate_ResidTask");
            });

            modelBuilder.Entity<ResidTaskSchedule>(entity =>
            {
                entity.HasKey(e => e.TaskscheduleId);

                entity.ToTable("ResidTaskSchedule");

                entity.Property(e => e.TaskscheduleId).HasColumnName("TaskscheduleID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TaskType).HasMaxLength(20);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ResidTaskSchedules)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_ResidTaskSchedule_ResidSection");
            });

            modelBuilder.Entity<ResidTaskType>(entity =>
            {
                entity.HasKey(e => e.TaskTypeId);

                entity.ToTable("ResidTaskType");

                entity.Property(e => e.TaskTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TaskTypeID");

                entity.Property(e => e.TaskTypeName).HasMaxLength(150);
            });

            modelBuilder.Entity<ResidTaskschedDetail>(entity =>
            {
                entity.HasKey(e => e.TaskscheduleDetaiId);

                entity.ToTable("ResidTaskschedDetail");

                entity.Property(e => e.TaskscheduleDetaiId).HasColumnName("TaskscheduleDetaiID");

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskscheduleId).HasColumnName("TaskscheduleID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ResidTaskschedDetails)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_ResidTaskschedDetail_ResidTask");

                entity.HasOne(d => d.Taskschedule)
                    .WithMany(p => p.ResidTaskschedDetails)
                    .HasForeignKey(d => d.TaskscheduleId)
                    .HasConstraintName("FK_ResidTaskschedDetail_ResidTaskSchedule");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("Semester");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.IsClosed)
                    .HasColumnName("IS_Closed")
                    .HasComment("تم انتهاء الفصل الدراسى");

                entity.Property(e => e.Semester1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Semester");

                entity.HasOne(d => d.YearNavigation)
                    .WithMany(p => p.Semesters)
                    .HasForeignKey(d => d.Year)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Semester_YearStudy");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("Session");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SessionName).HasMaxLength(50);
            });

            modelBuilder.Entity<SportAchievement>(entity =>
            {
                entity.HasKey(e => e.AchievementId);

                entity.ToTable("SportAchievement");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.AchievementName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<SportField>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("SportField");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Department).HasComment("القسم حيث المجالات تستخدم فى قسم التربية الرياضيةو الورش\r\n10-التربية الرياضية");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.WorkShopTypeId).HasColumnName("WorkShopTypeID");

                entity.HasOne(d => d.WorkShopType)
                    .WithMany(p => p.SportFields)
                    .HasForeignKey(d => d.WorkShopTypeId)
                    .HasConstraintName("FK_SportField_WorkShopType");
            });

            modelBuilder.Entity<SportLongTarget>(entity =>
            {
                entity.HasKey(e => e.LongTargetId);

                entity.ToTable("SportLongTarget");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.SportLongTargets)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportLongTarget_SportField");
            });

            modelBuilder.Entity<SportPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("SportPlan");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SportPlans)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportPlan_User");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.SportPlans)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportPlan_Student");
            });

            modelBuilder.Entity<SportReportStudent>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("SportReportStudent");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SportReportStudents)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportReportStudent_User");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.SportReportStudents)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportReportStudent_SportPlan");
            });

            modelBuilder.Entity<SportShortTarget>(entity =>
            {
                entity.HasKey(e => e.ShortTargetId);

                entity.ToTable("SportShortTarget");

                entity.Property(e => e.ShortTargetId).HasColumnName("ShortTargetID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.ShortTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.LongTarget)
                    .WithMany(p => p.SportShortTargets)
                    .HasForeignKey(d => d.LongTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportShortTarget_SportLongTarget");
            });

            modelBuilder.Entity<SportShortTargetPlan>(entity =>
            {
                entity.HasKey(e => e.ShortTargetPlanId);

                entity.ToTable("SportShortTargetPlan");

                entity.Property(e => e.ShortTargetPlanId).HasColumnName("ShortTargetPlanID");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.DateAchievement).HasColumnType("smalldatetime");

                entity.Property(e => e.IsDone).HasColumnName("IS_Done");

                entity.Property(e => e.Notes).HasMaxLength(550);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.ShortTargetId).HasColumnName("ShortTargetID");

                entity.HasOne(d => d.Achievement)
                    .WithMany(p => p.SportShortTargetPlans)
                    .HasForeignKey(d => d.AchievementId)
                    .HasConstraintName("FK_SportShortTargetPlan_SportAchievement");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.SportShortTargetPlans)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportShortTargetPlan_SportPlan");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.SportShortTargetPlans)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_SportShortTargetPlan_Semester");

                entity.HasOne(d => d.ShortTarget)
                    .WithMany(p => p.SportShortTargetPlans)
                    .HasForeignKey(d => d.ShortTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportShortTargetPlan_SportShortTarget");
            });

            modelBuilder.Entity<SportTargetAchievement>(entity =>
            {
                entity.HasKey(e => e.TargetAchievementId);

                entity.ToTable("SportTargetAchievement");

                entity.Property(e => e.TargetAchievementId).HasColumnName("TargetAchievementID");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.ShortTargetPlanId).HasColumnName("ShortTargetPlanID");

                entity.HasOne(d => d.Achievement)
                    .WithMany(p => p.SportTargetAchievements)
                    .HasForeignKey(d => d.AchievementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportTargetAchievement_SportAchievement");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday")
                    .HasComment("تاريخ الميلاد");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Complaint)
                    .HasMaxLength(350)
                    .HasComment("الشكوى");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasColumnName("CreatedBY");

                entity.Property(e => e.DateRegister)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ التسجيل");

                entity.Property(e => e.Diagnosis).HasMaxLength(250);

                entity.Property(e => e.DiagnosisDescription).HasMaxLength(450);

                entity.Property(e => e.FileNo).HasComment("رقم الملف");

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(150)
                    .HasColumnName("IDNumber")
                    .HasComment("رقم الهوية");

                entity.Property(e => e.IdnumberExpiryDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("IDNumberExpiryDate")
                    .HasComment("تاريخ نهاية الهوية");

                entity.Property(e => e.IdspecialCase)
                    .HasMaxLength(150)
                    .HasColumnName("IDSpecialCase")
                    .HasComment("رقم بطاقة اولي الهمم");

                entity.Property(e => e.IsResident)
                    .IsRequired()
                    .HasColumnName("IS_Resident")
                    .HasDefaultValueSql("((1))")
                    .HasComment("مقيم\r\n1- نعم مقيم\r\n0-لا");

                entity.Property(e => e.MedicalDiagnosis)
                    .HasMaxLength(350)
                    .HasComment("التشخيص الطبى");

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.NoCivilRegistry)
                    .HasMaxLength(150)
                    .HasComment("رقم السجل المدنى");

                entity.Property(e => e.PassportExpiryDate)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ انتهاء الباسبور");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(150)
                    .HasColumnName("PassportNO")
                    .HasComment("رقم الباسبور");

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(250)
                    .HasComment("صورة الطالب");

                entity.Property(e => e.ResidentDepId)
                    .HasColumnName("ResidentDepID")
                    .HasComment("السكن الداخلى");

                entity.Property(e => e.Serial).HasComment("رقم الملف");

                entity.Property(e => e.SerialPrev)
                    .HasMaxLength(50)
                    .HasComment("رقم الملف السابق");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SexType).HasComment("النوع\r\n0-ذكر\r\n1- انثى");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TransferDestination)
                    .HasMaxLength(150)
                    .HasComment("جهه التحويل");
            });

            modelBuilder.Entity<Support>(entity =>
            {
                entity.ToTable("Support");

                entity.Property(e => e.SupportId).HasColumnName("SupportID");

                entity.Property(e => e.ClinetId).HasColumnName("ClinetID");

                entity.Property(e => e.Message).HasMaxLength(550);

                entity.Property(e => e.PostDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Clinet)
                    .WithMany(p => p.Supports)
                    .HasForeignKey(d => d.ClinetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spport_Clinet");

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.InverseParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .HasConstraintName("FK_Spport_Spport");
            });

            modelBuilder.Entity<TableClass>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PK_Table");

                entity.ToTable("TableClass");

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.TypeClass).HasColumnName("typeClass");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.TableClasses)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_Semester");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TableClasses)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_HrEmployee");
            });

            modelBuilder.Entity<TableDet>(entity =>
            {
                entity.ToTable("TableDet");

                entity.Property(e => e.TableDetId).HasColumnName("TableDetID");

                entity.Property(e => e.DayNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.TypeClass)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.TableDets)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableDet_ClassSchedule");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TableDets)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableDet_EduSubject");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.TableDets)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TableDet_Table");
            });

            modelBuilder.Entity<TempNatAssesment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempNatAssesment");

                entity.Property(e => e.AssesmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AssesmentID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.NoteContact).HasMaxLength(350);

                entity.Property(e => e.NoteDeepTendonR)
                    .HasMaxLength(350)
                    .HasColumnName("Note_DeepTendonR");

                entity.Property(e => e.NoteFunassessment)
                    .HasMaxLength(350)
                    .HasColumnName("Note_funassessment");

                entity.Property(e => e.NoteMmt)
                    .HasMaxLength(350)
                    .HasColumnName("Note_MMT");

                entity.Property(e => e.NoteMuscleTone).HasMaxLength(350);

                entity.Property(e => e.NoteNervousSys).HasMaxLength(350);

                entity.Property(e => e.NoteRom)
                    .HasMaxLength(350)
                    .HasColumnName("Note_ROM");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<TempNutiAssesment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempNutiAssesment");

                entity.Property(e => e.ActivityLevelId).HasColumnName("ActivityLevelID");

                entity.Property(e => e.AssesmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AssesmentID");

                entity.Property(e => e.Attachment).HasMaxLength(150);

                entity.Property(e => e.Cho)
                    .HasMaxLength(50)
                    .HasColumnName("cho");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DietId).HasColumnName("DietID");

                entity.Property(e => e.Fats).HasMaxLength(50);

                entity.Property(e => e.Habits).HasMaxLength(150);

                entity.Property(e => e.PhysicActivityId).HasColumnName("PhysicActivityID");

                entity.Property(e => e.Physictherapy).HasMaxLength(50);

                entity.Property(e => e.Pro).HasMaxLength(50);

                entity.Property(e => e.RequirementKca)
                    .HasMaxLength(50)
                    .HasColumnName("RequirementKCA");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TexturesfoodId).HasColumnName("TexturesfoodID");

                entity.Property(e => e.WaterInk)
                    .HasMaxLength(50)
                    .HasColumnName("waterInk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AccessType).HasComment("1-مستخدم\r\n2-مدرس\r\n3-مشرف");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Photo)
                    .HasMaxLength(150)
                    .HasColumnName("photo");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_User_User");
            });

            modelBuilder.Entity<User1>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Users");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AllowDiscount)
                    .HasColumnName("Allow_Discount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deleted).HasComment("تم حذفه\r\nو هذا لمنع حذف اي مستخدم لما له من تأثير على طابع المستخدم");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("كلمة السر");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("مجموعة الصلاحيات");

                entity.Property(e => e.UserAllow).HasComment("السماح بالدخول");

                entity.Property(e => e.UserFullName)
                    .HasMaxLength(200)
                    .HasComment("الاسم بالكامل");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("اسم الدخول");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.User1s)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Users_hrEmployees");
            });

            modelBuilder.Entity<VwEduRptPlanStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Edu_Rpt_PlanStudent");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.DateRegister).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldName).HasMaxLength(150);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(150)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.IsApprove).HasColumnName("IS_Approve");

                entity.Property(e => e.IsApproveSuperVisor).HasColumnName("IS_ApproveSuperVisor");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MedicalDiagnosis).HasMaxLength(350);

                entity.Property(e => e.NotesLongTarget).HasMaxLength(350);

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanStudyId).HasColumnName("PlanStudyID");

                entity.Property(e => e.Semester).HasMaxLength(50);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.ShortTargetId).HasColumnName("ShortTargetID");

                entity.Property(e => e.ShortTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Supervisour).HasMaxLength(250);
            });

            modelBuilder.Entity<VwEduRptResponsePlanStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Edu_Rpt_ResponsePlanStudent");

                entity.Property(e => e.AnalysisName).HasMaxLength(150);

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateRegister).HasColumnType("smalldatetime");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldName).HasMaxLength(150);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(150)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.IsApproveSuperVisor).HasColumnName("IS_ApproveSuperVisor");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.LongTargetName).HasMaxLength(250);

                entity.Property(e => e.MedicalDiagnosis).HasMaxLength(350);

                entity.Property(e => e.NoteShortTarg).HasMaxLength(500);

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanReportId).HasColumnName("PlanReportID");

                entity.Property(e => e.PlanStudyId).HasColumnName("PlanStudyID");

                entity.Property(e => e.RepeatNo).HasColumnName("RepeatNO");

                entity.Property(e => e.ResponseName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Semester).HasMaxLength(150);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.ShortTargetId).HasColumnName("ShortTargetID");

                entity.Property(e => e.ShortTargetName).HasMaxLength(250);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic).HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish).HasMaxLength(250);

                entity.Property(e => e.Supervisour).HasMaxLength(250);

                entity.Property(e => e.TeacherName).HasMaxLength(250);
            });

            modelBuilder.Entity<VwNatRptAssessmentItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nat_Rpt_AssessmentItem");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(150)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.ItemGrpId).HasColumnName("ItemGrpID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ItemValue).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NoteContact).HasMaxLength(350);

                entity.Property(e => e.NoteDeepTendonR)
                    .HasMaxLength(350)
                    .HasColumnName("Note_DeepTendonR");

                entity.Property(e => e.NoteFunassessment)
                    .HasMaxLength(350)
                    .HasColumnName("Note_funassessment");

                entity.Property(e => e.NoteMmt)
                    .HasMaxLength(350)
                    .HasColumnName("Note_MMT");

                entity.Property(e => e.NoteMuscleTone).HasMaxLength(350);

                entity.Property(e => e.NoteNervousSys).HasMaxLength(350);

                entity.Property(e => e.NoteRom)
                    .HasMaxLength(350)
                    .HasColumnName("Note_ROM");

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.SerialPrev).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwNatRptAssessmentRom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nat_Rpt_AssessmentROM");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.CurrentRom).HasColumnName("CurrentROM");

                entity.Property(e => e.GrandId).HasColumnName("GrandID");

                entity.Property(e => e.Gromname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("GROMName");

                entity.Property(e => e.IsActive).HasColumnName("IS_Active");

                entity.Property(e => e.ItemRomId).HasColumnName("ItemRomID");

                entity.Property(e => e.ItemRomName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NormalValue).HasMaxLength(100);

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Promname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PROMName");

                entity.Property(e => e.Romid).HasColumnName("ROMID");

                entity.Property(e => e.Romname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ROMName");

                entity.Property(e => e.Strength).HasMaxLength(350);
            });

            modelBuilder.Entity<VwNatRptProgramStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nat_Rpt_ProgramStudent");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreateByName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.ProgStudDetailId).HasColumnName("ProgStudDetailID");

                entity.Property(e => e.ProgStudentId).HasColumnName("ProgStudentID");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwNatRptReportStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nat_Rpt_ReportStudent");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreateByName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Details).IsRequired();

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwNatTbNatRom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nat_tb_NatROM");

                entity.Property(e => e.GparentId).HasColumnName("GparentID");

                entity.Property(e => e.ItemRomId).HasColumnName("ItemRomID");

                entity.Property(e => e.ItemRomName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NormalValue).HasMaxLength(100);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PromName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PRomName");

                entity.Property(e => e.Romid).HasColumnName("ROMID");

                entity.Property(e => e.Romname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ROMName");
            });

            modelBuilder.Entity<VwNutiAssessmentStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_NutiAssessmentStudent");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CareGiver).HasMaxLength(250);

                entity.Property(e => e.DateRegister).HasColumnType("smalldatetime");

                entity.Property(e => e.MedicalDiagnosis).HasMaxLength(350);

                entity.Property(e => e.NationalityName).HasMaxLength(250);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionName).HasMaxLength(150);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SuperVisouer).HasMaxLength(250);
            });

            modelBuilder.Entity<VwNutiRptBcastudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nuti_Rpt_BCAStudent");

                entity.Property(e => e.Bcaid).HasColumnName("BCAID");

                entity.Property(e => e.Bmi).HasColumnName("BMI");

                entity.Property(e => e.Bmrid).HasColumnName("BMRID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Ecwl)
                    .HasMaxLength(50)
                    .HasColumnName("ECWL");

                entity.Property(e => e.Ecwlnrange)
                    .HasMaxLength(50)
                    .HasColumnName("ECWLNRange");

                entity.Property(e => e.Icwl).HasColumnName("ICWL");

                entity.Property(e => e.Icwlnrange)
                    .HasMaxLength(50)
                    .HasColumnName("ICWLNRange");

                entity.Property(e => e.Mbrname)
                    .HasMaxLength(150)
                    .HasColumnName("MBRName");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwNutiRptCardStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nuti_Rpt_CardStudent");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwOccRptAssessment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Occ_Rpt_assessment");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreateByUser)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Evaluation).HasMaxLength(150);

                entity.Property(e => e.ItemRomId).HasColumnName("ItemRomID");

                entity.Property(e => e.ItemRomName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NormalValue).HasMaxLength(100);

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.Promname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PROMName");

                entity.Property(e => e.ReEvaluation).HasMaxLength(150);

                entity.Property(e => e.Romid).HasColumnName("ROMID");

                entity.Property(e => e.Romname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ROMName");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwOccuRptPlanTargFinalReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Occu_Rpt_PlanTargFinalReport");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreateByUser).HasMaxLength(250);

                entity.Property(e => e.CurrentStatus).HasMaxLength(250);

                entity.Property(e => e.CurrentStatusId).HasColumnName("CurrentStatusID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MethodName).HasMaxLength(250);

                entity.Property(e => e.PlanTermId).HasColumnName("planTermID");

                entity.Property(e => e.Recomendation).HasMaxLength(350);

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ToolName).HasMaxLength(250);
            });

            modelBuilder.Entity<VwPronAssessmentInstruction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Pron_AssessmentInstruction");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.AssessmentInstId).HasColumnName("AssessmentInstID");

                entity.Property(e => e.Instruction)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.InstructionId).HasColumnName("InstructionID");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwPronAssessmentSoundLetter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Pron_assessmentSoundLetter");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.AssessmentSoundId).HasColumnName("AssessmentSoundID");

                entity.Property(e => e.IsSection).HasColumnName("IS_Section");

                entity.Property(e => e.IsSingle).HasColumnName("IS_Single");

                entity.Property(e => e.LetterName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SoundLetterId).HasColumnName("SoundLetterID");
            });

            modelBuilder.Entity<VwPronRptAssessment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_pron_Rpt_assessment");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.AttentConcentration).HasMaxLength(50);

                entity.Property(e => e.AttentConcentrationDesc).HasMaxLength(150);

                entity.Property(e => e.AttractAttention).HasMaxLength(50);

                entity.Property(e => e.AttractAttentionDesc).HasMaxLength(150);

                entity.Property(e => e.BegfirstWord).HasMaxLength(50);

                entity.Property(e => e.BehDuringAssessment).HasMaxLength(350);

                entity.Property(e => e.CanRecoizeVoice)
                    .HasMaxLength(50)
                    .HasColumnName("canRecoizeVoice");

                entity.Property(e => e.CommthroMoveGestureDesc).HasMaxLength(250);

                entity.Property(e => e.ControlThroat).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DirectionSound).HasMaxLength(50);

                entity.Property(e => e.ExpressiveSummary).HasMaxLength(250);

                entity.Property(e => e.EyeContact).HasMaxLength(50);

                entity.Property(e => e.EyeContactDesc).HasMaxLength(150);

                entity.Property(e => e.GesturesSummary).HasMaxLength(250);

                entity.Property(e => e.HasArticulationPhonic).HasMaxLength(50);

                entity.Property(e => e.HasNasalityDisorders).HasMaxLength(50);

                entity.Property(e => e.HasNasalityDisordersDesc).HasMaxLength(150);

                entity.Property(e => e.HasSpeechEcholalia).HasMaxLength(50);

                entity.Property(e => e.HasSuttering).HasMaxLength(50);

                entity.Property(e => e.HasSutteringDesc).HasMaxLength(150);

                entity.Property(e => e.HasVoiceDisorder).HasMaxLength(50);

                entity.Property(e => e.HascongenitalDefect).HasMaxLength(50);

                entity.Property(e => e.ImitationMotor).HasMaxLength(50);

                entity.Property(e => e.ImitationMotorDesc).HasMaxLength(150);

                entity.Property(e => e.ImitationVoice).HasMaxLength(50);

                entity.Property(e => e.ImitationVoiceDesc).HasMaxLength(150);

                entity.Property(e => e.IsAphasia)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Aphasia");

                entity.Property(e => e.IsApraxia)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Apraxia");

                entity.Property(e => e.IsDysarthia)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Dysarthia");

                entity.Property(e => e.Jaws).HasMaxLength(50);

                entity.Property(e => e.JawsDescrib).HasMaxLength(250);

                entity.Property(e => e.KnowSound)
                    .HasMaxLength(50)
                    .HasColumnName("knowSound");

                entity.Property(e => e.Lips).HasMaxLength(50);

                entity.Property(e => e.LipsDescrib).HasMaxLength(250);

                entity.Property(e => e.MovBackTongue).HasMaxLength(150);

                entity.Property(e => e.MoveDesc).HasMaxLength(150);

                entity.Property(e => e.MovementLips).HasMaxLength(150);

                entity.Property(e => e.MovementSoft).HasMaxLength(150);

                entity.Property(e => e.MovementVelar).HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NasalCavity).HasMaxLength(50);

                entity.Property(e => e.NasalCavityDescrib).HasMaxLength(250);

                entity.Property(e => e.ObservationAssessment).HasMaxLength(350);

                entity.Property(e => e.OrofacialExamId).HasColumnName("OrofacialExamID");

                entity.Property(e => e.Palate)
                    .HasMaxLength(150)
                    .HasColumnName("palate");

                entity.Property(e => e.ReceptiveSummry).HasMaxLength(250);

                entity.Property(e => e.RecognizeSound).HasMaxLength(50);

                entity.Property(e => e.Recomendation).HasMaxLength(350);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SimpleInstructionsDesc).HasMaxLength(250);

                entity.Property(e => e.SoftPalateDescrib).HasMaxLength(250);

                entity.Property(e => e.Softpalate).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Teeth).HasMaxLength(50);

                entity.Property(e => e.TeethDescrib).HasMaxLength(250);

                entity.Property(e => e.ThreeWordSentenceConve).HasMaxLength(100);

                entity.Property(e => e.ThreeWordSentenceDesc).HasMaxLength(100);

                entity.Property(e => e.Tongue).HasMaxLength(50);

                entity.Property(e => e.TongueDescrib).HasMaxLength(250);

                entity.Property(e => e.Tonsils).HasMaxLength(50);

                entity.Property(e => e.TonsilsDescrib).HasMaxLength(250);

                entity.Property(e => e.TurnTakingDurPlaying).HasMaxLength(50);

                entity.Property(e => e.TurnTakingDurPlayingDesc).HasMaxLength(150);

                entity.Property(e => e.TwoWordSentenceConve).HasMaxLength(100);

                entity.Property(e => e.TwoWordSentenceDesc).HasMaxLength(100);

                entity.Property(e => e.Velar).HasMaxLength(50);

                entity.Property(e => e.VelarDescrib).HasMaxLength(250);
            });

            modelBuilder.Entity<VwPronRptAssessmentInstruction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Pron_Rpt_AssessmentInstruction");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.AssessmentInstId).HasColumnName("AssessmentInstID");

                entity.Property(e => e.Instruction)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.InstructionId).HasColumnName("InstructionID");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwPronRptPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Pron_Rpt_Plan");

                entity.Property(e => e.Achievement).HasMaxLength(100);

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("createBy");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DatePlan).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis).HasMaxLength(550);

                entity.Property(e => e.Goals).HasMaxLength(250);

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.PlanTargetId).HasColumnName("PlanTargetID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwPronRptPronAssessmentMove>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Pron_Rpt_PronAssessmentMove");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.AssessmentMoveId).HasColumnName("AssessmentMoveID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MoveCategoryId).HasColumnName("MoveCategoryID");

                entity.Property(e => e.Movement)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MovementId).HasColumnName("MovementID");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwPronRptPronAssessmnetVocab>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Pron_Rpt_PronAssessmnetVocab");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.AssessmnetVocabId).HasColumnName("AssessmnetVocabID");

                entity.Property(e => e.IsExpress).HasColumnName("IS_Express");

                entity.Property(e => e.IsGesture).HasColumnName("IS_Gesture");

                entity.Property(e => e.IsUnderstand).HasColumnName("IS_Understand");

                entity.Property(e => e.VocabCategory)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.VocabCategoryId).HasColumnName("VocabCategoryID");

                entity.Property(e => e.VocabId).HasColumnName("VocabID");

                entity.Property(e => e.Vocabularies)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwPronTbPronAssessment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Pron_tb_PronAssessment");

                entity.Property(e => e.ArrangeChild).HasMaxLength(50);

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.AttentConcentration).HasMaxLength(50);

                entity.Property(e => e.AttentConcentrationDesc).HasMaxLength(150);

                entity.Property(e => e.AttractAttention).HasMaxLength(50);

                entity.Property(e => e.AttractAttentionDesc).HasMaxLength(150);

                entity.Property(e => e.BegfirstWord).HasMaxLength(50);

                entity.Property(e => e.BehDuringAssessment).HasMaxLength(350);

                entity.Property(e => e.BreathingProblems).HasMaxLength(50);

                entity.Property(e => e.BreathingProblemsDescrib).HasMaxLength(150);

                entity.Property(e => e.CanRecoizeVoice)
                    .HasMaxLength(50)
                    .HasColumnName("canRecoizeVoice");

                entity.Property(e => e.ChildLive).HasMaxLength(50);

                entity.Property(e => e.CircumstanceBirth).HasMaxLength(50);

                entity.Property(e => e.Cognitive).HasMaxLength(50);

                entity.Property(e => e.CognitiveDescrib).HasMaxLength(150);

                entity.Property(e => e.CommthroMoveGestureDesc).HasMaxLength(250);

                entity.Property(e => e.CommunicationDisorder).HasMaxLength(500);

                entity.Property(e => e.ControlThroat).HasMaxLength(150);

                entity.Property(e => e.CrampsEpilepsy).HasMaxLength(50);

                entity.Property(e => e.CrampsEpilepsyDescrib).HasMaxLength(50);

                entity.Property(e => e.Crawling).HasMaxLength(50);

                entity.Property(e => e.CrawlingDescrib).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DescribedMotoProb).HasMaxLength(350);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.DescriptionIssueStatus).HasMaxLength(350);

                entity.Property(e => e.DirectionSound).HasMaxLength(50);

                entity.Property(e => e.ExpressiveSummary).HasMaxLength(250);

                entity.Property(e => e.EyeContact).HasMaxLength(50);

                entity.Property(e => e.EyeContactDesc).HasMaxLength(150);

                entity.Property(e => e.FamilyMemhasdiagnosis)
                    .HasMaxLength(50)
                    .HasColumnName("familyMemhasdiagnosis");

                entity.Property(e => e.FamilyMemhasdiagnosisDescrib)
                    .HasMaxLength(150)
                    .HasColumnName("familyMemhasdiagnosisDescrib");

                entity.Property(e => e.GesturesSummary).HasMaxLength(250);

                entity.Property(e => e.HasArticulationPhonic).HasMaxLength(50);

                entity.Property(e => e.HasNasalityDisorders).HasMaxLength(50);

                entity.Property(e => e.HasNasalityDisordersDesc).HasMaxLength(150);

                entity.Property(e => e.HasSpeechEcholalia).HasMaxLength(50);

                entity.Property(e => e.HasSuttering).HasMaxLength(50);

                entity.Property(e => e.HasSutteringDesc).HasMaxLength(150);

                entity.Property(e => e.HasVoiceDisorder).HasMaxLength(50);

                entity.Property(e => e.HasVoiceDisorderDesc).HasMaxLength(150);

                entity.Property(e => e.HascongenitalDefect).HasMaxLength(50);

                entity.Property(e => e.Hearing).HasMaxLength(50);

                entity.Property(e => e.HearingDescrib).HasMaxLength(150);

                entity.Property(e => e.HowGuardians).HasMaxLength(350);

                entity.Property(e => e.HowProblemStarted).HasMaxLength(350);

                entity.Property(e => e.ImitationMotor).HasMaxLength(50);

                entity.Property(e => e.ImitationMotorDesc).HasMaxLength(150);

                entity.Property(e => e.ImitationVoice).HasMaxLength(50);

                entity.Property(e => e.ImitationVoiceDesc).HasMaxLength(150);

                entity.Property(e => e.IsAphasia)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Aphasia");

                entity.Property(e => e.IsApraxia)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Apraxia");

                entity.Property(e => e.IsDysarthia)
                    .HasMaxLength(50)
                    .HasColumnName("IS_Dysarthia");

                entity.Property(e => e.Jaws).HasMaxLength(50);

                entity.Property(e => e.JawsDescrib).HasMaxLength(250);

                entity.Property(e => e.KnowSound)
                    .HasMaxLength(50)
                    .HasColumnName("knowSound");

                entity.Property(e => e.Lips).HasMaxLength(50);

                entity.Property(e => e.LipsDescrib).HasMaxLength(250);

                entity.Property(e => e.MedicalCaseId).HasColumnName("MedicalCaseID");

                entity.Property(e => e.Motor).HasMaxLength(20);

                entity.Property(e => e.MovBackTongue).HasMaxLength(150);

                entity.Property(e => e.MoveDesc).HasMaxLength(150);

                entity.Property(e => e.MovementLips).HasMaxLength(150);

                entity.Property(e => e.MovementSoft).HasMaxLength(150);

                entity.Property(e => e.MovementVelar).HasMaxLength(150);

                entity.Property(e => e.NasalCavity).HasMaxLength(50);

                entity.Property(e => e.NasalCavityDescrib).HasMaxLength(250);

                entity.Property(e => e.NoteMotor).HasMaxLength(450);

                entity.Property(e => e.ObservationAssessment).HasMaxLength(350);

                entity.Property(e => e.OrofacialExamId).HasColumnName("OrofacialExamID");

                entity.Property(e => e.Palate)
                    .HasMaxLength(150)
                    .HasColumnName("palate");

                entity.Property(e => e.ReceptiveSummry).HasMaxLength(250);

                entity.Property(e => e.RecognizeSound).HasMaxLength(50);

                entity.Property(e => e.Recomendation).HasMaxLength(350);

                entity.Property(e => e.RelationBparent)
                    .HasMaxLength(50)
                    .HasColumnName("RelationBParent");

                entity.Property(e => e.RunnySaliva).HasMaxLength(50);

                entity.Property(e => e.RunnySalivaDescrib).HasMaxLength(150);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SimpleInstructionsDesc).HasMaxLength(250);

                entity.Property(e => e.Sitting).HasMaxLength(50);

                entity.Property(e => e.SittingDescrib).HasMaxLength(50);

                entity.Property(e => e.SocailHisId).HasColumnName("SocailHisID");

                entity.Property(e => e.SocialStatusParents)
                    .HasMaxLength(50)
                    .HasColumnName("socialStatusParents");

                entity.Property(e => e.SoftPalateDescrib).HasMaxLength(250);

                entity.Property(e => e.Softpalate).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Surgery)
                    .HasMaxLength(50)
                    .HasColumnName("surgery");

                entity.Property(e => e.SurgeryDescrib)
                    .HasMaxLength(150)
                    .HasColumnName("surgeryDescrib");

                entity.Property(e => e.SwallowingProb).HasMaxLength(50);

                entity.Property(e => e.SwallowingProbDescrib).HasMaxLength(150);

                entity.Property(e => e.TakeMedicine).HasMaxLength(50);

                entity.Property(e => e.TakeMedicineDescrib).HasMaxLength(150);

                entity.Property(e => e.TakeSpecMedicine).HasMaxLength(50);

                entity.Property(e => e.TakeSpecMedicineDescrib).HasMaxLength(150);

                entity.Property(e => e.Teeth).HasMaxLength(50);

                entity.Property(e => e.TeethDescrib).HasMaxLength(250);

                entity.Property(e => e.ThreeWordSentenceConve).HasMaxLength(100);

                entity.Property(e => e.ThreeWordSentenceDesc).HasMaxLength(100);

                entity.Property(e => e.Tongue).HasMaxLength(50);

                entity.Property(e => e.TongueDescrib).HasMaxLength(250);

                entity.Property(e => e.Tonsils).HasMaxLength(50);

                entity.Property(e => e.TonsilsDescrib).HasMaxLength(250);

                entity.Property(e => e.TurnTakingDurPlaying).HasMaxLength(50);

                entity.Property(e => e.TurnTakingDurPlayingDesc).HasMaxLength(150);

                entity.Property(e => e.TwoWordSentenceConve).HasMaxLength(100);

                entity.Property(e => e.TwoWordSentenceDesc).HasMaxLength(100);

                entity.Property(e => e.Velar).HasMaxLength(50);

                entity.Property(e => e.VelarDescrib).HasMaxLength(250);

                entity.Property(e => e.Visual).HasMaxLength(50);

                entity.Property(e => e.VisualDescrib).HasMaxLength(150);

                entity.Property(e => e.Walking).HasMaxLength(50);

                entity.Property(e => e.WalkingDescrib).HasMaxLength(50);
            });

            modelBuilder.Entity<VwResidAbsenceStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Resid_AbsenceStudent");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StudentCount).HasColumnName("studentCount");
            });

            modelBuilder.Entity<VwResidRptOutPermssion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Resid_Rpt_OutPermssion");

                entity.Property(e => e.ActualReturnDate).HasColumnType("date");

                entity.Property(e => e.DateLeave).HasColumnType("date");

                entity.Property(e => e.DateReturn).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.NoteParent).HasMaxLength(250);

                entity.Property(e => e.NoteSupervisour).HasMaxLength(50);

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwResidRptTaskSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Resid_Rpt_TaskSchedule");

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskType).HasMaxLength(20);

                entity.Property(e => e.TaskTypeId).HasColumnName("TaskTypeID");

                entity.Property(e => e.TaskTypeName).HasMaxLength(150);

                entity.Property(e => e.Taskname)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TaskscheduleDetaiId).HasColumnName("TaskscheduleDetaiID");

                entity.Property(e => e.TaskscheduleId).HasColumnName("TaskscheduleID");
            });

            modelBuilder.Entity<VwRptEduEvalutionStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Rpt_EduEvalutionStudent");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateEvalution).HasColumnType("smalldatetime");

                entity.Property(e => e.DateRegister).HasColumnType("smalldatetime");

                entity.Property(e => e.Degree).HasMaxLength(50);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Diagnosis).HasMaxLength(250);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EvalutionId).HasColumnName("EvalutionID");

                entity.Property(e => e.FieldName).HasMaxLength(150);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NationalityName).HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.Recommendation).IsRequired();

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwRptPsyBehaviorForm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Rpt_PsyBehaviorForm");

                entity.Property(e => e.BehaviorFormId).HasColumnName("behaviorFormID");

                entity.Property(e => e.BehaviorMonitorId).HasColumnName("behaviorMonitorID");

                entity.Property(e => e.BehaviorNedModify)
                    .HasMaxLength(500)
                    .HasColumnName("behaviorNedModify");

                entity.Property(e => e.DateMonitor).HasColumnType("smalldatetime");

                entity.Property(e => e.DateSuggesFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateSuggesTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DescBehavior).HasMaxLength(500);

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.PeriodNotes)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PlanBehaviorId).HasColumnName("PlanBehaviorID");

                entity.Property(e => e.RepeatNo).HasColumnName("RepeatNO");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SourceInfo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<VwRptPsyCaseStudy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Rpt_PsyCaseStudy");

                entity.Property(e => e.Answer).IsRequired();

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.DateRegister).HasColumnType("smalldatetime");

                entity.Property(e => e.NationalityName).HasMaxLength(250);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VwRptPsyPlanModified>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Rpt_PsyPlanModified");

                entity.Property(e => e.BehavAnalysisItemId).HasColumnName("BehavAnalysisItemID");

                entity.Property(e => e.BehaviorFormId).HasColumnName("behaviorFormID");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ChildItemName).HasMaxLength(250);

                entity.Property(e => e.Examineby)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("examineby");

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.ParentItemName).HasMaxLength(250);

                entity.Property(e => e.PlanBehaviorId).HasColumnName("PlanBehaviorID");

                entity.Property(e => e.PostDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TargetPlane)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<VwSportPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Sport_Plan");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.AchievementName).HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DateAchievement).HasColumnType("smalldatetime");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IsDone).HasColumnName("IS_Done");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(550);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.PlanType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Semester).HasMaxLength(150);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.ShortTargetId).HasColumnName("ShortTargetID");

                entity.Property(e => e.ShortTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ShortTargetPlanId).HasColumnName("ShortTargetPlanID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<VwSportRptEvalution>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Sport_Rpt_Evalution");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreateByName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EvalutionId).HasColumnName("EvalutionID");

                entity.Property(e => e.EvalutionSkilId).HasColumnName("EvalutionSkilID");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.Recomendation).HasMaxLength(350);

                entity.Property(e => e.SkilId).HasColumnName("SkilID");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.WorkShopTypeId).HasColumnName("WorkShopTypeID");
            });

            modelBuilder.Entity<VwSportRptPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_sport_Rpt_plan");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.AchievementName).HasMaxLength(150);

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DateAchievement).HasColumnType("smalldatetime");

                entity.Property(e => e.DateReport).HasColumnType("smalldatetime");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IsDone).HasColumnName("IS_Done");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(550);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Semester)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.ShortTargetId).HasColumnName("ShortTargetID");

                entity.Property(e => e.ShortTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentNameArabic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StudentNameEnglish)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.WorkShopName).HasMaxLength(250);

                entity.Property(e => e.WorkShopTypeId).HasColumnName("WorkShopTypeID");
            });

            modelBuilder.Entity<VwTbNatItemValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_tb_NatItemValue");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ItemGrpId).HasColumnName("ItemGrpID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ItemValueId).HasColumnName("ItemValueID");
            });

            modelBuilder.Entity<WorkShopTeacher>(entity =>
            {
                entity.ToTable("WorkShopTeacher");

                entity.Property(e => e.WorkShopTeacherId)
                    .ValueGeneratedNever()
                    .HasColumnName("WorkShopTeacherID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.WorkShopTypeId).HasColumnName("WorkShopTypeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.WorkShopTeachers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkShopTeacher_HrEmployee");
            });

            modelBuilder.Entity<WorkShopType>(entity =>
            {
                entity.ToTable("WorkShopType");

                entity.Property(e => e.WorkShopTypeId).HasColumnName("WorkShopTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.WorkShopName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.WorkShopTypes)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_WorkShopType_HrEmployee");
            });

            modelBuilder.Entity<WsEvalutionStudent>(entity =>
            {
                entity.HasKey(e => e.EvalutionId);

                entity.ToTable("WsEvalutionStudent");

                entity.Property(e => e.EvalutionId).HasColumnName("EvalutionID");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Recomendation).HasMaxLength(350);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WsEvalutionStudents)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WsEvalutionStudent_User");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.WsEvalutionStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WsEvalutionStudent_Student");
            });

            modelBuilder.Entity<WsEvalutionStudentSkill>(entity =>
            {
                entity.HasKey(e => e.EvalutionSkilId);

                entity.ToTable("WsEvalutionStudentSkill");

                entity.Property(e => e.EvalutionSkilId).HasColumnName("EvalutionSkilID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EvalutionId).HasColumnName("EvalutionID");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.SkilId).HasColumnName("SkilID");

                entity.HasOne(d => d.Degree)
                    .WithMany(p => p.WsEvalutionStudentSkills)
                    .HasForeignKey(d => d.DegreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WsEvalutionStudentSkill_SportAchievement");

                entity.HasOne(d => d.Evalution)
                    .WithMany(p => p.WsEvalutionStudentSkills)
                    .HasForeignKey(d => d.EvalutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WsEvalutionStudentSkill_WsEvalutionStudent");

                entity.HasOne(d => d.Skil)
                    .WithMany(p => p.WsEvalutionStudentSkills)
                    .HasForeignKey(d => d.SkilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WsEvalutionStudentSkill_WsSkilI");
            });

            modelBuilder.Entity<WsSkilI>(entity =>
            {
                entity.HasKey(e => e.SkilId);

                entity.ToTable("WsSkilI");

                entity.Property(e => e.SkilId).HasColumnName("SkilID");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.WsSkilIs)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WsSkilI_SportField");
            });

            modelBuilder.Entity<YearStudy>(entity =>
            {
                entity.ToTable("YearStudy");

                entity.Property(e => e.YearStudyId).HasColumnName("YearStudyID");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.IsClosed).HasColumnName("IS_closed");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
