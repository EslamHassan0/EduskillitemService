using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiPlanStudent
    {
        public int PlanId { get; set; }
        public int StudentId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string Improvement { get; set; }
        public string Recomandation { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }

        public virtual Student Student { get; set; }
    }
}
