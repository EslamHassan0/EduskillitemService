using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public int? EmployeeId { get; set; }
        public string Name { get; set; }
        public int AccessType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public string Notes { get; set; }

        public virtual HrEmployee Employee { get; set; }
    }
}
