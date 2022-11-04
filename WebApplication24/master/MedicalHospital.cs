using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class MedicalHospital
    {
        public MedicalHospital()
        {
            MedicalHospitalVisits = new HashSet<MedicalHospitalVisit>();
        }

        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<MedicalHospitalVisit> MedicalHospitalVisits { get; set; }
    }
}
