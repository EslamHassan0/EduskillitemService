using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiAssesment
    {
        public NutiAssesment()
        {
            NutiAssesmentMins = new HashSet<NutiAssesmentMin>();
            NutiAssesmentVitimins = new HashSet<NutiAssesmentVitimin>();
        }

        public int AssesmentId { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public int? DietId { get; set; }
        public string Cho { get; set; }
        public string Fats { get; set; }
        public string Pro { get; set; }
        public string WaterInk { get; set; }
        public string RequirementKca { get; set; }
        public int? PhysicActivityId { get; set; }
        public string Physictherapy { get; set; }
        public int? ActivityLevelId { get; set; }
        public byte Action { get; set; }
        public int Createby { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }
        public int? TexturesfoodId { get; set; }
        public byte? SleepHour { get; set; }
        public byte? MealFreq { get; set; }
        public string Habits { get; set; }
        public string Attachment { get; set; }
        public bool? IsActive { get; set; }

        public virtual NutiDiet Diet { get; set; }
        public virtual Student Student { get; set; }
        public virtual NutiTexturesfood Texturesfood { get; set; }
        public virtual ICollection<NutiAssesmentMin> NutiAssesmentMins { get; set; }
        public virtual ICollection<NutiAssesmentVitimin> NutiAssesmentVitimins { get; set; }
    }
}
