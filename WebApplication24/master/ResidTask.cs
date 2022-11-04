using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidTask
    {
        public ResidTask()
        {
            ResidTaskDates = new HashSet<ResidTaskDate>();
            ResidTaskschedDetails = new HashSet<ResidTaskschedDetail>();
        }

        public int TaskId { get; set; }
        public string Taskname { get; set; }
        public int? Hours { get; set; }
        public int? Minute { get; set; }
        public byte? ShiftType { get; set; }
        public int? Period { get; set; }
        public byte? TaskTypeId { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual ResidTaskType TaskType { get; set; }
        public virtual ICollection<ResidTaskDate> ResidTaskDates { get; set; }
        public virtual ICollection<ResidTaskschedDetail> ResidTaskschedDetails { get; set; }
    }
}
