using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiDiet
    {
        public NutiDiet()
        {
            NutiAssesments = new HashSet<NutiAssesment>();
            NutiDientPlans = new HashSet<NutiDientPlan>();
            NutiMealTimeTables = new HashSet<NutiMealTimeTable>();
        }

        public int DietId { get; set; }
        public string DietName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<NutiAssesment> NutiAssesments { get; set; }
        public virtual ICollection<NutiDientPlan> NutiDientPlans { get; set; }
        public virtual ICollection<NutiMealTimeTable> NutiMealTimeTables { get; set; }
    }
}
