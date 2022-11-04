using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication24.Service
{
    public partial class ServiceContext : DbContext
    {
        public ServiceContext()
        {
        }

        public ServiceContext(DbContextOptions<ServiceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }
        public virtual DbSet<ClClinic> ClClinics { get; set; }
        public virtual DbSet<ClClinicsDoctor> ClClinicsDoctors { get; set; }
        public virtual DbSet<ClCompany> ClCompanies { get; set; }
        public virtual DbSet<ClCompanyFile> ClCompanyFiles { get; set; }
        public virtual DbSet<ClMenu> ClMenus { get; set; }
        public virtual DbSet<ClMenuService> ClMenuServices { get; set; }
        public virtual DbSet<ClPatient> ClPatients { get; set; }
        public virtual DbSet<ClReservationTime> ClReservationTimes { get; set; }
        public virtual DbSet<ClService> ClServices { get; set; }
        public virtual DbSet<ClTicket> ClTickets { get; set; }
        public virtual DbSet<ClTicketService> ClTicketServices { get; set; }
        public virtual DbSet<Clinet> Clinets { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<Hash> Hashes { get; set; }
        public virtual DbSet<HrEmployee> HrEmployees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobParameter> JobParameters { get; set; }
        public virtual DbSet<JobQueue> JobQueues { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Schema> Schemas { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Support> Supports { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TF0HS6G;Database=Service;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

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

            modelBuilder.Entity<ClCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("clCompanies");

                entity.HasComment("ÇáÔÑßÇÊ ÇáÊÇÈÚ áåÇ ÇáãÑÖì");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ChildrenDisc)
                    .HasDefaultValueSql("((0))")
                    .HasComment("äÓÈÉ ÇáÎÕã ááÇÈäÇÁ");

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(250)
                    .HasComment("ÇáÈÑíÏ ÇáÇáßÊÑæäí ááÔÑßÉ");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasComment("ÇÓã ÇáÔÑßÉ");

                entity.Property(e => e.CompanyPerson)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("ÇáÔÎÕ ÇáãÓÆæá");

                entity.Property(e => e.CompanyStartDate)
                    .HasColumnType("smalldatetime")
                    .HasComment("ÊÇÑíÎ ÈÏÇíÉ ÇáÊÚÇãá");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnName("currentBalance")
                    .HasComment("ÇáÑÕíÏ ÇáÍÇáì");

                entity.Property(e => e.MemberDisc).HasComment("äÓÈÉ ÇáÎÕã ááÚÖæ");

                entity.Property(e => e.MenuId)
                    .HasColumnName("MenuID")
                    .HasComment("ãÓáÓá ÇáÞÇÆãÉ ÇáÊÇÈÚÉ áåÇ ÇáÔÑßÉ");

                entity.Property(e => e.Notes).HasComment("ãáÇÍÙÇÊ");

                entity.Property(e => e.ParentsDisc)
                    .HasDefaultValueSql("((0))")
                    .HasComment("äÓÈÉ ÇáÎÕã ááÇÈÇÁ");

                entity.Property(e => e.SpouseDisc)
                    .HasDefaultValueSql("((0))")
                    .HasComment("äÓÈÉ ÇáÎÕã ááÒæÌ Çæ ÇáÒæÌÉ");

                entity.Property(e => e.TypePayed)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1-ãÞÏã \r\n2-ÃÌá ");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.ClCompanies)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_clCompanies_clMenus1");
            });

            modelBuilder.Entity<ClCompanyFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("clCompanyFiles");

                entity.HasComment("ãÓÊäÏÇÊ æÕæÑ");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasComment("ãÓáÓá ÇáÌÏæá ÇáÇÈ áåÐå ÇáãáÝÇÊ");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("ÇÓã ÇáãáÝ Úáì ÇáÞÑÕ ÇáÕáÈ");

                entity.Property(e => e.FileTitle)
                    .HasMaxLength(50)
                    .HasComment("ÚäæÇä ÇáãáÝ ÇáÐí íÙåÑ Ýí ÇáÊÚÇãá ÏÇÎá ÇáÈÑäÇãÌ");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ClCompanyFiles)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_clCompanyFiles_clCompany");
            });

            modelBuilder.Entity<ClMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.ToTable("clMenus");

                entity.HasComment("قوائم الاسعار المختلفة للشركات");

                entity.HasIndex(e => e.MenuName, "IX_clMenus");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.DiscountRatio).HasComment("نسبة الخصم الافتراضية");

                entity.Property(e => e.IsSyndicate).HasColumnName("IS_Syndicate");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasComment("اسم القائمة");

                entity.Property(e => e.Notes).HasComment("ملاحظات");

                entity.Property(e => e.Type)
                    .HasDefaultValueSql("((1))")
                    .HasComment("النوع \r\n1- خصم\r\n2- زياده \r\nمعنى زياده  انه ممكن تستخدم الشركه نظام اجل فيتم زياده للاسعار لها ");
            });

            modelBuilder.Entity<ClMenuService>(entity =>
            {
                entity.HasKey(e => e.MenuServiceId);

                entity.ToTable("clMenuServices");

                entity.HasComment("س");

                entity.Property(e => e.MenuServiceId).HasColumnName("MenuServiceID");

                entity.Property(e => e.IsDelete).HasColumnName("IS_Delete");

                entity.Property(e => e.IsSyndicate).HasColumnName("IS_Syndicate");

                entity.Property(e => e.MenuId)
                    .HasColumnName("MenuID")
                    .HasComment("مسلسل القائمة");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("ServiceID")
                    .HasComment("مسلسل الخدمة");

                entity.Property(e => e.ServicePrice).HasComment("سعر الخدمة");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.ClMenuServices)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_clMenuServices_clMenus1");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ClMenuServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_clMenuServices_clServices");
            });

            modelBuilder.Entity<ClPatient>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("clPatients");

                entity.HasComment("ÇáãÑÖì");

                entity.HasIndex(e => new { e.PatientName, e.PatientRelation, e.PatientntOn, e.CompanyId }, "IX_clPatients")
                    .IsUnique();

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Blood).HasMaxLength(50);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasComment("ãÓáÓá ÇáÔÑßÉ ÇáÊÇÈÚ áåÇ Åä æÏÌÏ");

                entity.Property(e => e.EmployeeNoInCompany).HasComment("ÑÞã ÇáãæÙÝ Ýì ÇáÔÑßå");

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasComment("ãÓáÓá ÇáãåäÉ ãä bmJobs");

                entity.Property(e => e.MemberName).HasMaxLength(150);

                entity.Property(e => e.NationalityId)
                    .HasMaxLength(100)
                    .HasColumnName("NationalityID");

                entity.Property(e => e.PatientAddress).HasComment("ÇáÚäæÇä");

                entity.Property(e => e.PatientBirthDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PatientHistory).HasComment("ÇáÊÇÑíÎ ÇáÚáÇÌí æ ÇáãÑÖí ááãÑíÖ");

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasComment("ÇÓã ÇáãÑíÖ");

                entity.Property(e => e.PatientRandomId).HasColumnName("PatientRandomID");

                entity.Property(e => e.PatientRelation).HasComment("ÏÑÌÉ ÇáÞÑÇÈÉ\r\n=======\r\nÝí ÍÇáÉ ßÇä ÇáãÑíÖ ÊÇÈÚ áÔÑßÉ ÝáÇÈÏ ãä ãÚÑÝÉ ÏÑÌÉ ÞÑÇÈÉ ÇáãÑíÖ ãä ÇáãæÙÝ Ýí ÇáÔÑßÉ áãÚÑÝÉ ÇáÎÕã ÇáÐí ÓíÍÕá Úáíå\r\n1 ÇáÚÖæ\r\n2 ÇáÒæÌ Çæ ÇáÒæÌÉ\r\n3 ÇáÇÈäÇÁ\r\n4 ÇáæÇáÏíä");

                entity.Property(e => e.PatientTel)
                    .HasMaxLength(150)
                    .HasComment("ÇáÊáíÝæäÇÊ");

                entity.Property(e => e.RelaionType).HasComment("äæÚ ÇáÚáÇÞå ÈÇáÚÖæ");

                entity.Property(e => e.Sex).HasComment("0----> male\r\n1---->Female");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ClPatients)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_clPatients_clCompanies1");
            });

            modelBuilder.Entity<ClReservationTime>(entity =>
            {
                entity.HasKey(e => e.ReservationTimeId)
                    .HasName("PK_clReservationTimes_1");

                entity.ToTable("clReservationTimes");

                entity.HasComment("جدول مواعيد العيادات المختلفة");

                entity.Property(e => e.ReservationTimeId).HasColumnName("ReservationTimeID");

                entity.Property(e => e.ClinicId)
                    .HasColumnName("ClinicID")
                    .HasComment("مسلسل العيادة");

                entity.Property(e => e.Day).HasComment("رقم اليوم في الاسبوع مثلا السبت 0 و الاحد 1");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("مسلسل الطبيب");

                entity.Property(e => e.FromTime).HasComment("من الساعة");

                entity.Property(e => e.FromTimeType).HasComment("Am ----1\r\nPm------2");

                entity.Property(e => e.PostDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShiftType)
                    .HasColumnName("shiftType")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1-صباحيه\r\n2-مسائيه");

                entity.Property(e => e.ToTime).HasComment("الى الساعة");

                entity.Property(e => e.ToTimeType).HasComment("Am ----1\r\nPm------2");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ClReservationTimes)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_clReservationTimes_hrEmployees");
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

            modelBuilder.Entity<ClTicket>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.ToTable("clTickets");

                entity.HasComment("شاشة استقبال المرضى و قطع التذاكر");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.ApproveNo).HasMaxLength(50);

                entity.Property(e => e.ApproveResponseability).HasMaxLength(150);

                entity.Property(e => e.ClinicId)
                    .HasColumnName("ClinicID")
                    .HasComment("مسلسل العيادة");

                entity.Property(e => e.Complaint).HasComment("الشكوى الخاصة بالمريض");

                entity.Property(e => e.Diagnosis).HasComment("تشخيص الطبيب");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.EmergencyCompany)
                    .HasColumnName("emergencyCompany")
                    .HasComment("تستخدم فى حاله الشركات\r\n0- حاله عاديه له جواب محول به من الشركه\r\n1- فى الحالات العاجله . وجود حادثه و هكذا . بيدخل من غير جواب تحويل من الشركه");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("مسلسل الطبي المتواجد المقطوع باسمه الكوبون");

                entity.Property(e => e.GetNursing).HasComment("له الحق في الحصول على التمريض");

                entity.Property(e => e.GetReports).HasComment("يستخدم لمعرفة اذا كان المريض حصل على تقرير طبى ام لأ\r\n0-- لم يحصل على تقرير طبى\r\n1--- حصل على تقرير طبى");

                entity.Property(e => e.IsDetection).HasColumnName("Is_Detection");

                entity.Property(e => e.IsRemainMoney)
                    .HasColumnName("IS_RemainMoney")
                    .HasComment("فى حالة دفع الفلوس على جزئين");

                entity.Property(e => e.IsShareDocEmerg).HasColumnName("IS_shareDocEmerg");

                entity.Property(e => e.LetterDateCompany)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("letterDateCompany");

                entity.Property(e => e.Notes).HasComment("ملاحظات");

                entity.Property(e => e.Nursed).HasComment("تم تمريضه");

                entity.Property(e => e.NursingResult).HasComment("نتيجة التمريض");

                entity.Property(e => e.PatientId)
                    .HasColumnName("PatientID")
                    .HasComment("مسلسل المريض");

                entity.Property(e => e.PatientType).HasComment("نوع الحالة\r\n=====\r\n1 عاجلة -- طواريء\r\n2 محوله من المركز\r\n3 خارجية افراد \r\n4 خارجية  شركات");

                entity.Property(e => e.PayedType).HasComment("نوع الدفع\r\n1- نقدى\r\n2-فيزا");

                entity.Property(e => e.PrintNo)
                    .HasDefaultValueSql("((1))")
                    .HasComment("يستخدم لمعرفه هذا الكوبون طبع كام مره");

                entity.Property(e => e.RequestScansTicketId)
                    .HasColumnName("RequestScans_TicketID")
                    .HasComment("هذا الفيلد يحمل رقم\r\nticketId \r\nالمطلوب عمل تحاليل لها");

                entity.Property(e => e.ReservationId)
                    .HasColumnName("ReservationID")
                    .HasComment("مسلسل الحجز في حالة ان المريض حاجز مسبقا");

                entity.Property(e => e.ReturnNotes).HasComment("ملاحظات الارجاع");

                entity.Property(e => e.ReturnUserId)
                    .HasColumnName("ReturnUserID")
                    .HasComment("المستخدم الذي قام بالارجاع");

                entity.Property(e => e.Returned).HasComment("تم ارجاعه");

                entity.Property(e => e.ShiftType)
                    .HasColumnName("shiftType")
                    .HasComment("نوع الشيفت\r\n1- صباحى\r\n2-مسائى");

                entity.Property(e => e.TicketDate)
                    .HasColumnType("smalldatetime")
                    .HasComment("التاريخ");

                entity.Property(e => e.TicketRandomId).HasColumnName("ticketRandomID");

                entity.Property(e => e.TicketSerial).HasComment("الكود مسلسل على العيادة حسب الساعة خلال اليوم\r\nيبدأ الكود بمسلسل بعد عدد الحاجزين في العيادة من شاشة الحجز المسبق\r\n\r\nو اذا كانت هذه التذكرة لشخص حاجز قبل ذلك يأخذ رقم حسب ترتيبة في جدول الحجز للعيادة والوقت و الطبيب المختارين");

                entity.Property(e => e.TicketTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Total).HasComment("اجمالى التذكره بعد الخصم . فى حاله الشركات");

                entity.Property(e => e.TreasuryId)
                    .HasColumnName("TreasuryID")
                    .HasComment("الخزينة الصادر منها التذكرة\r\nallow nullتستخدم ب \r\nنظرا فى حاله اضافه تذكره جديده عن طريق الطبيب عند اضافه خدمات من عيادات اخرى");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("المستخدم الذي اصدر هذا الكوبون من الخزينة\r\n\r\nallow nullتستخدم ب \r\nنظرا فى حاله اضافه تذكره جديده عن طريق الطبيب عند اضافه خدمات من عيادات اخرى");
            });

            modelBuilder.Entity<ClTicketService>(entity =>
            {
                entity.HasKey(e => e.TicketServiceId);

                entity.ToTable("clTicketServices");

                entity.HasComment("الخدمات الحاصل عليه المريض في هذا الكشف");

                entity.Property(e => e.TicketServiceId).HasColumnName("TicketServiceID");

                entity.Property(e => e.Price).HasComment("سعر الخدمة");

                entity.Property(e => e.Qty).HasComment("الخصم");

                entity.Property(e => e.Result)
                    .HasMaxLength(500)
                    .HasComment("النتيجة في حالة خدمات التمريض");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("ServiceID")
                    .HasComment("الخدمة");

                entity.Property(e => e.TicketId)
                    .HasColumnName("TicketID")
                    .HasComment("تذكرة الحجز");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ClTicketServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_clTicketServices_clServices");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.ClTicketServices)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK_clTicketServices_clTickets");
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

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key, "CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmployee>(entity =>
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

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameters)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
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

            modelBuilder.Entity<User>(entity =>
            {
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
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Users_hrEmployees");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
