using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiFood
    {
        public NutiFood()
        {
            NutiFoodIngredients = new HashSet<NutiFoodIngredient>();
            NutiFoodMealTypes = new HashSet<NutiFoodMealType>();
            NutiFoodPrefernceDets = new HashSet<NutiFoodPrefernceDet>();
            NutiMealTimeFoods = new HashSet<NutiMealTimeFood>();
            NutiMealTimeTables = new HashSet<NutiMealTimeTable>();
        }

        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int GroupId { get; set; }
        public string Measure { get; set; }
        public int UniteId { get; set; }
        public string Calories { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual NutiFoodGroup Group { get; set; }
        public virtual NutiFoodUnite Unite { get; set; }
        public virtual ICollection<NutiFoodIngredient> NutiFoodIngredients { get; set; }
        public virtual ICollection<NutiFoodMealType> NutiFoodMealTypes { get; set; }
        public virtual ICollection<NutiFoodPrefernceDet> NutiFoodPrefernceDets { get; set; }
        public virtual ICollection<NutiMealTimeFood> NutiMealTimeFoods { get; set; }
        public virtual ICollection<NutiMealTimeTable> NutiMealTimeTables { get; set; }
    }
}
