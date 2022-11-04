using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class ClCompanyFile
    {
        public int FileId { get; set; }
        public int CompanyId { get; set; }
        public string FileTitle { get; set; }
        public string FileName { get; set; }

        public virtual ClCompany Company { get; set; }
    }
}
