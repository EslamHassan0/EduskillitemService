using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class User
    {
        public User()
        {
            EduPlanStudies = new HashSet<EduPlanStudy>();
            NatStudentReports = new HashSet<NatStudentReport>();
            SportPlans = new HashSet<SportPlan>();
            SportReportStudents = new HashSet<SportReportStudent>();
            WsEvalutionStudents = new HashSet<WsEvalutionStudent>();
        }

        public int UserId { get; set; }
        public int? EmployeeId { get; set; }
        public string Name { get; set; }
        public int AccessType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public string Notes { get; set; }
        public string Photo { get; set; }

        public virtual HrEmployee Employee { get; set; }
        public virtual ICollection<EduPlanStudy> EduPlanStudies { get; set; }
        public virtual ICollection<NatStudentReport> NatStudentReports { get; set; }
        public virtual ICollection<SportPlan> SportPlans { get; set; }
        public virtual ICollection<SportReportStudent> SportReportStudents { get; set; }
        public virtual ICollection<WsEvalutionStudent> WsEvalutionStudents { get; set; }
    }
}
