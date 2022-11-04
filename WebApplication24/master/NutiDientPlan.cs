using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiDientPlan
    {
        public NutiDientPlan()
        {
            NutiDietPlanDets = new HashSet<NutiDietPlanDet>();
        }

        public int DietPlanId { get; set; }
        public int DietId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public virtual NutiDiet Diet { get; set; }
        public virtual ICollection<NutiDietPlanDet> NutiDietPlanDets { get; set; }
    }
}
