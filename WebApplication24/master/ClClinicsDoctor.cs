using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ClClinicsDoctor
    {
        public int ClinicDoctorId { get; set; }
        public int ClinicId { get; set; }
        public int EmployeeId { get; set; }
        public byte PrecentageHospial { get; set; }
        public byte PercentageDoctor { get; set; }
        public bool? DelayFeesComp { get; set; }
        public bool IsUseMiniCharge { get; set; }
        public float? MiniTargetClinicValue { get; set; }
        public float? ValueDoctor { get; set; }

        public virtual ClClinic Clinic { get; set; }
        public virtual HrEmployee1 Employee { get; set; }
    }
}
