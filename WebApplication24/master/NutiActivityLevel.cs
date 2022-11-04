using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiActivityLevel
    {
        public int ActivityLevelId { get; set; }
        public string ActivityLevel { get; set; }
        public byte SessionId { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte Action { get; set; }
    }
}
