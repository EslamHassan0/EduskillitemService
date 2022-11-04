using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiDietPlanDet
    {
        public int DietPlanDetId { get; set; }
        public int DietPlanId { get; set; }
        public string Day { get; set; }
        public int MealTimeId { get; set; }

        public virtual NutiDientPlan DietPlan { get; set; }
        public virtual NutiMealTime MealTime { get; set; }
    }
}
