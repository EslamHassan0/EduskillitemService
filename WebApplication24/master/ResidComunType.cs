using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidComunType
    {
        public ResidComunType()
        {
            ResidNoteComunities = new HashSet<ResidNoteComunity>();
        }

        public byte ComunTypeId { get; set; }
        public string ComunType { get; set; }

        public virtual ICollection<ResidNoteComunity> ResidNoteComunities { get; set; }
    }
}
