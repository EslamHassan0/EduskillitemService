using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiFoodIngredient
    {
        public int FodIngredientId { get; set; }
        public int FoodId { get; set; }
        public int IngredientId { get; set; }

        public virtual NutiFood Food { get; set; }
        public virtual NutiBaseIngredient Ingredient { get; set; }
    }
}
