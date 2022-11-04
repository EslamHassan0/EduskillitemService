using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidTaskSchedule
    {
        public ResidTaskSchedule()
        {
            ResidTaskschedDetails = new HashSet<ResidTaskschedDetail>();
        }

        public int TaskscheduleId { get; set; }
        public int? SectionId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string TaskType { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual ResidSection Section { get; set; }
        public virtual ICollection<ResidTaskschedDetail> ResidTaskschedDetails { get; set; }
    }
}
