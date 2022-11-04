using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class HrEmployee1
    {
        public HrEmployee1()
        {
            ClClinicsDoctors = new HashSet<ClClinicsDoctor>();
            User1s = new HashSet<User1>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhoto { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeTelephones { get; set; }
        public byte? EmployeeSexType { get; set; }
        public DateTime? EmployeeBirthDate { get; set; }
        public string IdentityCardNo { get; set; }
        public int? IdentityCardTypeId { get; set; }
        public DateTime? IdentityCardDate { get; set; }
        public string IdentityCardPlace { get; set; }
        public int? SocialStatusTypeId { get; set; }
        public int? ChildrenNo { get; set; }
        public byte? DutyPositionType { get; set; }
        public DateTime? OutDutyDate { get; set; }
        public string OutDutyReason { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public byte? ContractType { get; set; }
        public string ContractNo { get; set; }
        public int? DepId { get; set; }
        public int? CategoryId { get; set; }
        public string WorkOfficeRegistration { get; set; }
        public DateTime? WorkOfficeRegDate { get; set; }
        public string SocialSecurityNo { get; set; }
        public byte? EmployeeHireType { get; set; }
        public string EmployeeNotes { get; set; }
        public int? BankId { get; set; }
        public string BankAccount { get; set; }
        public int? ProjectId { get; set; }
        public int? ReligionId { get; set; }
        public int? NationalityId { get; set; }
        public string ResidenceNo { get; set; }
        public string ResidenceIssuePlace { get; set; }
        public DateTime? ResidenceStartDate { get; set; }
        public DateTime? ResidenceEndDate { get; set; }
        public string PassportNo { get; set; }
        public string PassportIssuePlace { get; set; }
        public DateTime? PassportStartDate { get; set; }
        public DateTime? PassportEndDate { get; set; }
        public string DriveLicenseNo { get; set; }
        public string DriveLicenseIssuePlace { get; set; }
        public DateTime? DriveLicenseStartDate { get; set; }
        public DateTime? DriveLicenseEndDate { get; set; }
        public byte? DocSalaryType { get; set; }
        public float? DocSalaryValue { get; set; }
        public byte? Tax { get; set; }

        public virtual ICollection<ClClinicsDoctor> ClClinicsDoctors { get; set; }
        public virtual ICollection<User1> User1s { get; set; }
    }
}
