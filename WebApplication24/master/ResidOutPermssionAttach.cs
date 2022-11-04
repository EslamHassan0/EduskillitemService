using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidOutPermssionAttach
    {
        public int OutPermiAttachId { get; set; }
        public int PermissionId { get; set; }
        public int PersAttachId { get; set; }
        public DateTime Date { get; set; }
        public bool? IsOut { get; set; }

        public virtual ResidOutPermssion Permission { get; set; }
        public virtual ResidPersonalAttach PersAttach { get; set; }
    }
}
