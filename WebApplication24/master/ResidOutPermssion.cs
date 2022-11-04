using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidOutPermssion
    {
        public ResidOutPermssion()
        {
            ResidOutPermssionAttaches = new HashSet<ResidOutPermssionAttach>();
        }

        public int PermissionId { get; set; }
        public int? StudentId { get; set; }
        public string Name { get; set; }
        public DateTime? DateLeave { get; set; }
        public TimeSpan? TimeLeave { get; set; }
        public DateTime? DateReturn { get; set; }
        public TimeSpan? TimeReturn { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public TimeSpan? ActualReturnTime { get; set; }
        public string NoteParent { get; set; }
        public string NoteSupervisour { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<ResidOutPermssionAttach> ResidOutPermssionAttaches { get; set; }
    }
}
