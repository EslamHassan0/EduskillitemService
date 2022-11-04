using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class ClCompany
    {
        public ClCompany()
        {
            ClCompanyFiles = new HashSet<ClCompanyFile>();
            ClPatients = new HashSet<ClPatient>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? MenuId { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPerson { get; set; }
        public DateTime CompanyStartDate { get; set; }
        public float MemberDisc { get; set; }
        public float? SpouseDisc { get; set; }
        public float? ChildrenDisc { get; set; }
        public float? ParentsDisc { get; set; }
        public string Notes { get; set; }
        public byte? TypePayed { get; set; }
        public double? CurrentBalance { get; set; }

        public virtual ClMenu Menu { get; set; }
        public virtual ICollection<ClCompanyFile> ClCompanyFiles { get; set; }
        public virtual ICollection<ClPatient> ClPatients { get; set; }
    }
}
