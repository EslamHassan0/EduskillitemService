using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ClClinic
    {
        public ClClinic()
        {
            ClClinicsDoctors = new HashSet<ClClinicsDoctor>();
        }

        public int ClinicId { get; set; }
        public string ClinicName { get; set; }
        public byte DiagnosisPeriod { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<ClClinicsDoctor> ClClinicsDoctors { get; set; }
    }
}
