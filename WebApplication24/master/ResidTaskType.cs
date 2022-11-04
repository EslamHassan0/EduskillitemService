using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidTaskType
    {
        public ResidTaskType()
        {
            ResidTasks = new HashSet<ResidTask>();
        }

        public byte TaskTypeId { get; set; }
        public string TaskTypeName { get; set; }

        public virtual ICollection<ResidTask> ResidTasks { get; set; }
    }
}
