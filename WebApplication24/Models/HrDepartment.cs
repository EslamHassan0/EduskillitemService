using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class HrDepartment
    {
        public int DepartmentId { get; set; }
        public int? Parent { get; set; }
        public int? ManagerId { get; set; }
        public string DepartmentName { get; set; }
        public string Notes { get; set; }
    }
}
