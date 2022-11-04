using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiFoodIntoleranceDet
    {
        public int IntoleranceDetId { get; set; }
        public int FodIntoleranceId { get; set; }
        public int IngredientId { get; set; }

        public virtual NutiFoodIntolerance FodIntolerance { get; set; }
        public virtual NutiBaseIngredient Ingredient { get; set; }
    }
}
