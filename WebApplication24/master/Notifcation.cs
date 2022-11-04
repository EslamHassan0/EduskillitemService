using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class Notifcation
    {
        public int NotifcationId { get; set; }
        public int? NotificationType { get; set; }
        public DateTime? Date { get; set; }
        public int? FromUserId { get; set; }
        public int? FromDepId { get; set; }
        public int? ToUserId { get; set; }
        public int? ToDep { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Url { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsDeleted { get; set; }
        public byte? Session { get; set; }
        public string Parm1Key { get; set; }
        public string Parm1Value { get; set; }
        public string Parm2Key { get; set; }
        public string Parm2Value2 { get; set; }
    }
}
