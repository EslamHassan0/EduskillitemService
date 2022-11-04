using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuReportStudent
    {
        public int ReportId { get; set; }
        public int StudentId { get; set; }
        public string BodyPosition { get; set; }
        public string DailyActivities { get; set; }
        public string PlayMovement { get; set; }
        public string PreWritingSkills { get; set; }
        public string SocialActivities { get; set; }
        public string RestSleep { get; set; }
        public string SensorySkills { get; set; }
        public string Recommendation { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int SessionId { get; set; }

        public virtual Student Student { get; set; }
    }
}
