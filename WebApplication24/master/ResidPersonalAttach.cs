using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidPersonalAttach
    {
        public ResidPersonalAttach()
        {
            ResidOutPermssionAttaches = new HashSet<ResidOutPermssionAttach>();
        }

        public int PersAttachId { get; set; }
        public int StudentId { get; set; }
        public string AttachName { get; set; }
        public bool? IsOut { get; set; }
        public DateTime? LdateIn { get; set; }
        public DateTime? LdateOut { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<ResidOutPermssionAttach> ResidOutPermssionAttaches { get; set; }
    }
}
