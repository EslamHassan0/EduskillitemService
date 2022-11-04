using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EndTimePlan
    {
        public int EndTimeId { get; set; }
        public int DepartmentId { get; set; }
        public int SemesterId { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }

        public virtual Semester Semester { get; set; }
    }
}
