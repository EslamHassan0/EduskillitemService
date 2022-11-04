using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class TableClass
    {
        public TableClass()
        {
            TableDets = new HashSet<TableDet>();
        }

        public int TableId { get; set; }
        public byte TypeClass { get; set; }
        public string ClassName { get; set; }
        public int TeacherId { get; set; }
        public int SemesterId { get; set; }
        public string Notes { get; set; }
        public byte SessionId { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte Action { get; set; }

        public virtual Semester Semester { get; set; }
        public virtual HrEmployee Teacher { get; set; }
        public virtual ICollection<TableDet> TableDets { get; set; }
    }
}
