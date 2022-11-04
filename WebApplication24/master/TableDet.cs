using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class TableDet
    {
        public int TableDetId { get; set; }
        public int TableId { get; set; }
        public int SubjectId { get; set; }
        public string DayNo { get; set; }
        public int ScheduleId { get; set; }
        public string TypeClass { get; set; }

        public virtual ClassSchedule Schedule { get; set; }
        public virtual EduSubject Subject { get; set; }
        public virtual TableClass Table { get; set; }
    }
}
