using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiMealTime
    {
        public NutiMealTime()
        {
            NutiDietPlanDets = new HashSet<NutiDietPlanDet>();
            NutiMealTimeFoods = new HashSet<NutiMealTimeFood>();
        }

        public int MealTimeId { get; set; }
        public string MealName { get; set; }
        public byte MealTypeId { get; set; }
        public byte? Hour { get; set; }
        public byte? Minute { get; set; }
        public string Am { get; set; }
        public byte? Duration { get; set; }

        public virtual NutiMealType MealType { get; set; }
        public virtual ICollection<NutiDietPlanDet> NutiDietPlanDets { get; set; }
        public virtual ICollection<NutiMealTimeFood> NutiMealTimeFoods { get; set; }
    }
}
