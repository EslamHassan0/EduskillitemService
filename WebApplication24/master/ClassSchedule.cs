using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ClassSchedule
    {
        public ClassSchedule()
        {
            TableDets = new HashSet<TableDet>();
        }

        public int ScheduleId { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public string ClassNo { get; set; }
        public byte SessionId { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte Action { get; set; }

        public virtual ICollection<TableDet> TableDets { get; set; }
    }
}
