using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class WorkShopTeacher
    {
        public int WorkShopTeacherId { get; set; }
        public int WorkShopTypeId { get; set; }
        public int EmployeeId { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual HrEmployee Employee { get; set; }
    }
}
