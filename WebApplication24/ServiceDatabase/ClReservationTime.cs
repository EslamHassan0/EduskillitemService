using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class ClReservationTime
    {
        public int ReservationTimeId { get; set; }
        public int ClinicId { get; set; }
        public byte Day { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? PostDate { get; set; }
        public byte? FromTimeType { get; set; }
        public byte? ToTimeType { get; set; }
        public byte ShiftType { get; set; }

        public virtual HrEmployee Employee { get; set; }
    }
}
