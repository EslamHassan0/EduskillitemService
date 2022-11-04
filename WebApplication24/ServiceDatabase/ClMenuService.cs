using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class ClMenuService
    {
        public int MenuServiceId { get; set; }
        public int MenuId { get; set; }
        public int ServiceId { get; set; }
        public float ServicePrice { get; set; }
        public bool IsDelete { get; set; }
        public bool? IsSyndicate { get; set; }

        public virtual ClMenu Menu { get; set; }
        public virtual ClService Service { get; set; }
    }
}
