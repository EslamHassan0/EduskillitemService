using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication24.Models
{
    public partial class erpContext : DbContext
    {
        public erpContext()
        {
        }

        public erpContext(DbContextOptions<erpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EduAnalysisItem> EduAnalysisItems { get; set; }
        public virtual DbSet<EduEvalutionDegree> EduEvalutionDegrees { get; set; }
        public virtual DbSet<EduEvalutionStudent> EduEvalutionStudents { get; set; }
        public virtual DbSet<EduEvalutionStudent1> EduEvalutionStudents1 { get; set; }
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
        public virtual DbSet<EduTeachingAid> EduTeachingAids { get; set; }
        public virtual DbSet<EndTimePlan> EndTimePlans { get; set; }
        public virtual DbSet<HrDepartment> HrDepartments { get; set; }
        public virtual DbSet<HrEmployee> HrEmployees { get; set; }
        public virtual DbSet<HrJob> HrJobs { get; set; }
        public virtual DbSet<NatAssesment> NatAssesments { get; set; }
        public virtual DbSet<NatAssesmentItem> NatAssesmentItems { get; set; }
        public virtual DbSet<NatAssesmentRom> NatAssesmentRoms { get; set; }
        public virtual DbSet<NatItem> NatItems { get; set; }
        public virtual DbSet<NatItemGroup> NatItemGroups { get; set; }
        public virtual DbSet<NatItemValue> NatItemValues { get; set; }
        public virtual DbSet<NatProgStudent> NatProgStudents { get; set; }
        public virtual DbSet<NatProgStudentDetail> NatProgStudentDetails { get; set; }
        public virtual DbSet<NatProgram> NatPrograms { get; set; }
        public virtual DbSet<NatRom> NatRoms { get; set; }
        public virtual DbSet<NatRomitem> NatRomitems { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Product> Products { get; set; }
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
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<View1> View1s { get; set; }
        public virtual DbSet<View2> View2s { get; set; }
        public virtual DbSet<VwEduRptPlanStudent> VwEduRptPlanStudents { get; set; }
        public virtual DbSet<VwEduRptResponsePlanStudent> VwEduRptResponsePlanStudents { get; set; }
        public virtual DbSet<VwRptPsyBehaviorForm> VwRptPsyBehaviorForms { get; set; }
        public virtual DbSet<VwRptPsyCaseStudy> VwRptPsyCaseStudies { get; set; }
        public virtual DbSet<VwRptPsyPlanModified> VwRptPsyPlanModifieds { get; set; }
        public virtual DbSet<YearStudy> YearStudies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TF0HS6G;Database=erp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

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

            modelBuilder.Entity<EduEvalutionStudent1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EduEvalutionStudents");

                entity.Property(e => e.DateEvalution)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ التقييم المبدىء");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EvalutionId)
                    .HasColumnName("EvalutionID")
                    .HasComment("مسلسل التقيم المبدىء للطالب");

                entity.Property(e => e.EvalutionSlilId).HasColumnName("EvalutionSlilID");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.Recommendation)
                    .IsRequired()
                    .HasComment("التوصية و الملاحظات");
            });

            modelBuilder.Entity<EduEvalutionStudentSkill>(entity =>
            {
                entity.HasKey(e => e.EvalutionSlilId)
                    .HasName("PK_EduEvalutionStudentField");

                entity.ToTable("EduEvalutionStudentSkill");

                entity.Property(e => e.EvalutionSlilId)
                    .HasColumnName("EvalutionSlilID")
                    .HasComment("مسلسل تقييم المهارات");

                entity.Property(e => e.DegreeId)
                    .HasColumnName("DegreeID")
                    .HasComment("مسلسل درجة التقييم");

                entity.Property(e => e.EvalutionId)
                    .HasColumnName("EvalutionID")
                    .HasComment("مسلسل التقييم");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .HasComment("ملاحظات");

                entity.Property(e => e.SkillD).HasComment("مسلسل المهارة");

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

                entity.HasOne(d => d.SkillDNavigation)
                    .WithMany(p => p.EduEvalutionStudentSkills)
                    .HasForeignKey(d => d.SkillD)
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

                entity.Property(e => e.PlanStudyId)
                    .HasColumnName("PlanStudyID")
                    .HasComment("مسمسل الخطة التربيوية\r\nفى حالة عدم ادخال مسلسل خطة تربية سوف يكون الهدف هنا نموذج للاهداف يمكن تمريره للطلاب بعد ذلك عند اختياره");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.EduPlanLongTargets)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EduPlanLongTarget_EduField");

                entity.HasOne(d => d.PlanStudy)
                    .WithMany(p => p.EduPlanLongTargets)
                    .HasForeignKey(d => d.PlanStudyId)
                    .HasConstraintName("FK_EduPlanLongTarget_EduPlanStudy");
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

                entity.Property(e => e.SemesterId)
                    .HasColumnName("SemesterID")
                    .HasComment("مسلسل الفصل الدراسى");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasComment("مسلسل الطالب");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.EduPlanStudies)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
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

                entity.HasIndex(e => new { e.ShortTargetId, e.AnalysisItemId }, "IX_EduShortTargetAnalysis")
                    .IsUnique();

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

                entity.Property(e => e.EncourageTargId)
                    .ValueGeneratedNever()
                    .HasColumnName("EncourageTargID");

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

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.EndTimePlans)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EndTimePlan_Semester");
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

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NameEnglish).HasMaxLength(250);
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

            modelBuilder.Entity<NatAssesment>(entity =>
            {
                entity.HasKey(e => e.AssesmentId);

                entity.ToTable("NatAssesment");

                entity.Property(e => e.AssesmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("AssesmentID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(350);

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatAssesmentItem_NatItemValue");
            });

            modelBuilder.Entity<NatAssesmentRom>(entity =>
            {
                entity.HasKey(e => e.AssesmentRomid);

                entity.ToTable("NatAssesmentROM");

                entity.Property(e => e.AssesmentRomid).HasColumnName("AssesmentROMID");

                entity.Property(e => e.AssesmentId).HasColumnName("AssesmentID");

                entity.Property(e => e.CurrentRom).HasColumnName("CurrentROM");

                entity.Property(e => e.IsActive).HasColumnName("IS_Active");

                entity.Property(e => e.ItemRomId).HasColumnName("ItemRomID");

                entity.Property(e => e.Notes).HasMaxLength(350);

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

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<NatRom>(entity =>
            {
                entity.HasKey(e => e.Romid);

                entity.ToTable("NatROM");

                entity.Property(e => e.Romid).HasColumnName("ROMID");

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

                entity.Property(e => e.Romid).HasColumnName("ROMID");

                entity.HasOne(d => d.Rom)
                    .WithMany(p => p.NatRomitems)
                    .HasForeignKey(d => d.Romid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatROMItem_NatROM");
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

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Productname).HasMaxLength(50);

                entity.Property(e => e.Sales).HasColumnName("sales");

                entity.Property(e => e.SalesMonths).HasColumnName("sales months");
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

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_User_User");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SkillItemId).HasColumnName("SkillItemID");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<View2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_2");

                entity.Property(e => e.FieldName).HasMaxLength(150);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SkillItemId).HasColumnName("SkillItemID");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<VwEduRptPlanStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Edu_Rpt_PlanStudent");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.DateRegister).HasColumnType("smalldatetime");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.FieldName).HasMaxLength(150);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(150)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.IsApproveSuperVisor).HasColumnName("IS_ApproveSuperVisor");

                entity.Property(e => e.LongTargetId).HasColumnName("LongTargetID");

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MedicalDiagnosis).HasMaxLength(350);

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanStudyId).HasColumnName("PlanStudyID");

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
            });

            modelBuilder.Entity<VwEduRptResponsePlanStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Edu_Rpt_ResponsePlanStudent");

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

                entity.Property(e => e.LongTargetName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MedicalDiagnosis).HasMaxLength(350);

                entity.Property(e => e.NoteShortTarg).HasMaxLength(500);

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanReportId).HasColumnName("PlanReportID");

                entity.Property(e => e.PlanStudyId).HasColumnName("PlanStudyID");

                entity.Property(e => e.RepeatNo).HasColumnName("RepeatNO");

                entity.Property(e => e.Report).IsRequired();

                entity.Property(e => e.ResponseName)
                    .IsRequired()
                    .HasMaxLength(150);

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
