using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class Counter
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
