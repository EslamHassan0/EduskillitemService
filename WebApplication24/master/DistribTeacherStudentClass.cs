using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class DistribTeacherStudentClass
    {
        public int TeacherStudId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public int SemesterId { get; set; }

        public virtual Semester Semester { get; set; }
        public virtual Student Student { get; set; }
        public virtual HrEmployee Teacher { get; set; }
    }
}
