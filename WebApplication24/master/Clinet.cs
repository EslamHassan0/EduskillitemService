using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class Clinet
    {
        public Clinet()
        {
            Supports = new HashSet<Support>();
        }

        public int ClinetId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public DateTime? PostDate { get; set; }

        public virtual ICollection<Support> Supports { get; set; }
    }
}
