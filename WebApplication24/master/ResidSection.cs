using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidSection
    {
        public ResidSection()
        {
            ResidNoteDailies = new HashSet<ResidNoteDaily>();
            ResidRooms = new HashSet<ResidRoom>();
            ResidTaskDates = new HashSet<ResidTaskDate>();
            ResidTaskSchedules = new HashSet<ResidTaskSchedule>();
        }

        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int SuperVisouerId { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int Session { get; set; }

        public virtual ICollection<ResidNoteDaily> ResidNoteDailies { get; set; }
        public virtual ICollection<ResidRoom> ResidRooms { get; set; }
        public virtual ICollection<ResidTaskDate> ResidTaskDates { get; set; }
        public virtual ICollection<ResidTaskSchedule> ResidTaskSchedules { get; set; }
    }
}
