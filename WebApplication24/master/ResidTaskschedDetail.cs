using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidTaskschedDetail
    {
        public int TaskscheduleDetaiId { get; set; }
        public int? TaskscheduleId { get; set; }
        public int? TaskId { get; set; }
        public byte? Day { get; set; }

        public virtual ResidTask Task { get; set; }
        public virtual ResidTaskSchedule Taskschedule { get; set; }
    }
}
