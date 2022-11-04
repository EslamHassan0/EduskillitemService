using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class HrEmployee
    {
        public HrEmployee()
        {
            Users = new HashSet<User>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string NameEnglish { get; set; }
        public int? DepartmentId { get; set; }
        public int? JobId { get; set; }
        public int? ManagerId { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
