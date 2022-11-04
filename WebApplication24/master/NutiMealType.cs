using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiMealType
    {
        public NutiMealType()
        {
            NutiFoodMealTypes = new HashSet<NutiFoodMealType>();
            NutiMealTimes = new HashSet<NutiMealTime>();
        }

        public byte MealTypeId { get; set; }
        public string MealName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual ICollection<NutiFoodMealType> NutiFoodMealTypes { get; set; }
        public virtual ICollection<NutiMealTime> NutiMealTimes { get; set; }
    }
}
