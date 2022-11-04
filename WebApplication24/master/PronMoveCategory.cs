using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronMoveCategory
    {
        public PronMoveCategory()
        {
            PronMovements = new HashSet<PronMovement>();
        }

        public int MoveCategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<PronMovement> PronMovements { get; set; }
    }
}
