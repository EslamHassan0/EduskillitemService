using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class YearStudy
    {
        public YearStudy()
        {
            Semesters = new HashSet<Semester>();
        }

        public int YearStudyId { get; set; }
        public int Year { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool IsClosed { get; set; }

        public virtual ICollection<Semester> Semesters { get; set; }
    }
}
