using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiPhysicalActivity
    {
        public int PhysicActivityId { get; set; }
        public string PhysicName { get; set; }
        public byte Action { get; set; }
        public int Createby { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }
    }
}
