using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class ClMenu
    {
        public ClMenu()
        {
            ClCompanies = new HashSet<ClCompany>();
            ClMenuServices = new HashSet<ClMenuService>();
        }

        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public float DiscountRatio { get; set; }
        public float? DiscountRelationRatio { get; set; }
        public string Notes { get; set; }
        public byte? Type { get; set; }
        public bool? IsSyndicate { get; set; }

        public virtual ICollection<ClCompany> ClCompanies { get; set; }
        public virtual ICollection<ClMenuService> ClMenuServices { get; set; }
    }
}
