using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiBaseIngredient
    {
        public NutiBaseIngredient()
        {
            NutiFoodIngredients = new HashSet<NutiFoodIngredient>();
            NutiFoodIntoleranceDets = new HashSet<NutiFoodIntoleranceDet>();
        }

        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual ICollection<NutiFoodIngredient> NutiFoodIngredients { get; set; }
        public virtual ICollection<NutiFoodIntoleranceDet> NutiFoodIntoleranceDets { get; set; }
    }
}
