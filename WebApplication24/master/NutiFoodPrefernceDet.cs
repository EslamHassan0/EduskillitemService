using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiFoodPrefernceDet
    {
        public int FodPrefernceDetId { get; set; }
        public int FodPrefernceId { get; set; }
        public int FoodId { get; set; }
        public bool IsLike { get; set; }

        public virtual NutiFoodPrefernce FodPrefernce { get; set; }
        public virtual NutiFood Food { get; set; }
    }
}
