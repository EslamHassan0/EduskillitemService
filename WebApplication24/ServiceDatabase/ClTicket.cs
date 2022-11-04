using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class ClTicket
    {
        public ClTicket()
        {
            ClTicketServices = new HashSet<ClTicketService>();
        }

        public int TicketId { get; set; }
        public int? TicketSerial { get; set; }
        public DateTime TicketDate { get; set; }
        public int? TreasuryId { get; set; }
        public int ClinicId { get; set; }
        public int EmployeeId { get; set; }
        public byte? PatientType { get; set; }
        public int PatientId { get; set; }
        public int? ReservationId { get; set; }
        public bool GetNursing { get; set; }
        public float? TicketTotal { get; set; }
        public string Notes { get; set; }
        public bool Nursed { get; set; }
        public bool Diagnosed { get; set; }
        public string NursingResult { get; set; }
        public string Complaint { get; set; }
        public string Diagnosis { get; set; }
        public int? UserId { get; set; }
        public bool Returned { get; set; }
        public int? ReturnUserId { get; set; }
        public string ReturnNotes { get; set; }
        public int? RequestScansTicketId { get; set; }
        public int? ShiftType { get; set; }
        public bool GetReports { get; set; }
        public byte PrintNo { get; set; }
        public float? TotalDevelop { get; set; }
        public DateTime? LetterDateCompany { get; set; }
        public byte EmergencyCompany { get; set; }
        public float Total { get; set; }
        public byte? RelaionType { get; set; }
        public int? SerialPerClini { get; set; }
        public int? DoctorId { get; set; }
        public bool IsShareDocEmerg { get; set; }
        public bool? IsDetection { get; set; }
        public int? TicketRandomId { get; set; }
        public byte? PayedType { get; set; }
        public bool IsRemainMoney { get; set; }
        public string ApproveNo { get; set; }
        public string ApproveResponseability { get; set; }

        public virtual ICollection<ClTicketService> ClTicketServices { get; set; }
    }
}
