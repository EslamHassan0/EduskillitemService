using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiMealTimeFood
    {
        public int MealTimeFoodId { get; set; }
        public int MealTimeId { get; set; }
        public int FoodId { get; set; }

        public virtual NutiFood Food { get; set; }
        public virtual NutiMealTime MealTime { get; set; }
    }
}
