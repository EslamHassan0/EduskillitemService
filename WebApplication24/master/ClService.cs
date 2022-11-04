using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ClService
    {
        public int ServiceId { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public int? ClinicId { get; set; }
        public string ServiceName { get; set; }
        public float? ServicePrice { get; set; }
        public bool? IsService { get; set; }
        public bool? IsShow { get; set; }
        public bool? IsNotShareDoc { get; set; }
        public bool? SpeServiceComp { get; set; }
        public string Description { get; set; }
    }
}
