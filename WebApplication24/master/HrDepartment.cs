using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class HrDepartment
    {
        public HrDepartment()
        {
            EndTimePlans = new HashSet<EndTimePlan>();
            HrEmployees = new HashSet<HrEmployee>();
        }

        public int DepartmentId { get; set; }
        public int? Parent { get; set; }
        public int? ManagerId { get; set; }
        public string DepartmentName { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<EndTimePlan> EndTimePlans { get; set; }
        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
    }
}
