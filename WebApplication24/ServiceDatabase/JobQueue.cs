using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class JobQueue
    {
        public long Id { get; set; }
        public long JobId { get; set; }
        public string Queue { get; set; }
        public DateTime? FetchedAt { get; set; }
    }
}
