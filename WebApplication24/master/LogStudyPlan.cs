using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class LogStudyPlan
    {
        public int LogStudyId { get; set; }
        public int Pk { get; set; }
        public int? PlanStudyId { get; set; }
        public string TbName { get; set; }
        public int? StudentId { get; set; }
        public string TbDesc { get; set; }
        public string Details { get; set; }
        public int? Createtby { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
