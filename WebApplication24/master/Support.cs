using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class Support
    {
        public Support()
        {
            InverseParentNavigation = new HashSet<Support>();
        }

        public int SupportId { get; set; }
        public int Serial { get; set; }
        public int? Parent { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public byte Status { get; set; }
        public int ClinetId { get; set; }
        public DateTime PostDate { get; set; }

        public virtual Clinet Clinet { get; set; }
        public virtual Support ParentNavigation { get; set; }
        public virtual ICollection<Support> InverseParentNavigation { get; set; }
    }
}
