using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class HrEmployee
    {
        public HrEmployee()
        {
            DistribTeacherStudentClasses = new HashSet<DistribTeacherStudentClass>();
            ResidNoteCaregivers = new HashSet<ResidNoteCaregiver>();
            ResidNoteDailies = new HashSet<ResidNoteDaily>();
            TableClasses = new HashSet<TableClass>();
            Users = new HashSet<User>();
            WorkShopTeachers = new HashSet<WorkShopTeacher>();
            WorkShopTypes = new HashSet<WorkShopType>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string NameEnglish { get; set; }
        public int? DepartmentId { get; set; }
        public int? JobId { get; set; }
        public int? ManagerId { get; set; }

        public virtual HrDepartment Department { get; set; }
        public virtual ICollection<DistribTeacherStudentClass> DistribTeacherStudentClasses { get; set; }
        public virtual ICollection<ResidNoteCaregiver> ResidNoteCaregivers { get; set; }
        public virtual ICollection<ResidNoteDaily> ResidNoteDailies { get; set; }
        public virtual ICollection<TableClass> TableClasses { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WorkShopTeacher> WorkShopTeachers { get; set; }
        public virtual ICollection<WorkShopType> WorkShopTypes { get; set; }
    }
}
