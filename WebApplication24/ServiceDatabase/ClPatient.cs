using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class ClPatient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int Barcode { get; set; }
        public string PatientAddress { get; set; }
        public string PatientTel { get; set; }
        public DateTime PatientBirthDate { get; set; }
        public string NationalityId { get; set; }
        public int? JobId { get; set; }
        public int? CompanyId { get; set; }
        public byte? PatientRelation { get; set; }
        public string PatientHistory { get; set; }
        public bool Sex { get; set; }
        public int? EmployeeNoInCompany { get; set; }
        public int? RelaionType { get; set; }
        public int? PatientntOn { get; set; }
        public string Blood { get; set; }
        public int? PatientRandomId { get; set; }
        public int? UserId { get; set; }
        public string MemberName { get; set; }

        public virtual ClCompany Company { get; set; }
    }
}
