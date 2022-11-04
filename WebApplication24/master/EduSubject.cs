using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class EduSubject
    {
        public EduSubject()
        {
            TableDets = new HashSet<TableDet>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public byte SessionId { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte Action { get; set; }

        public virtual ICollection<TableDet> TableDets { get; set; }
    }
}
