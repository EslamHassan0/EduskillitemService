﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class AggregatedCounter
    {
        public string Key { get; set; }
        public long Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
