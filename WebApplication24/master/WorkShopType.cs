using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class WorkShopType
    {
        public WorkShopType()
        {
            SportFields = new HashSet<SportField>();
        }

        public int WorkShopTypeId { get; set; }
        public string WorkShopName { get; set; }
        public int? EmployeeId { get; set; }
        public byte Action { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte SessionId { get; set; }

        public virtual HrEmployee Employee { get; set; }
        public virtual ICollection<SportField> SportFields { get; set; }
    }
}
