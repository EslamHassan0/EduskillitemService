using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwResidRptTaskSchedule
    {
        public string SectionName { get; set; }
        public int TaskscheduleId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? SectionId { get; set; }
        public DateTime? EndDate { get; set; }
        public string TaskType { get; set; }
        public byte Action { get; set; }
        public string Taskname { get; set; }
        public int TaskscheduleDetaiId { get; set; }
        public int? Expr1 { get; set; }
        public int? TaskId { get; set; }
        public byte? Day { get; set; }
        public int? Hours { get; set; }
        public int? Minute { get; set; }
        public byte? ShiftType { get; set; }
        public int? Period { get; set; }
        public string TaskTypeName { get; set; }
        public byte? TaskTypeId { get; set; }
    }
}
