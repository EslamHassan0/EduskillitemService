using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiFoodMealType
    {
        public int FodMealTypeId { get; set; }
        public int FoodId { get; set; }
        public byte MealTypeId { get; set; }

        public virtual NutiFood Food { get; set; }
        public virtual NutiMealType MealType { get; set; }
    }
}
