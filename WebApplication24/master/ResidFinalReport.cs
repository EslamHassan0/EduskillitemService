using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidFinalReport
    {
        public ResidFinalReport()
        {
            ResidReportAssociBehavs = new HashSet<ResidReportAssociBehav>();
            ResidReportBehavPatterns = new HashSet<ResidReportBehavPattern>();
            ResidReportContParents = new HashSet<ResidReportContParent>();
            ResidReportExcelenActivs = new HashSet<ResidReportExcelenActiv>();
            ResidReportFavActivities = new HashSet<ResidReportFavActivity>();
            ResidReportRecomSupers = new HashSet<ResidReportRecomSuper>();
        }

        public int ReportId { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public string Description { get; set; }
        public string IsEasttingFood { get; set; }
        public string IsUseBathRoom { get; set; }
        public string IsWearing { get; set; }
        public string IsWearShose { get; set; }
        public string NotesSkill { get; set; }
        public bool? IsBehavToSelf { get; set; }
        public bool? IsBehavToOther { get; set; }
        public bool? IsBehavHarmBody { get; set; }
        public bool? IsBehavHarmAsset { get; set; }
        public string NoteBehavPattern { get; set; }
        public string DegreActivity { get; set; }
        public string NoteActivity { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<ResidReportAssociBehav> ResidReportAssociBehavs { get; set; }
        public virtual ICollection<ResidReportBehavPattern> ResidReportBehavPatterns { get; set; }
        public virtual ICollection<ResidReportContParent> ResidReportContParents { get; set; }
        public virtual ICollection<ResidReportExcelenActiv> ResidReportExcelenActivs { get; set; }
        public virtual ICollection<ResidReportFavActivity> ResidReportFavActivities { get; set; }
        public virtual ICollection<ResidReportRecomSuper> ResidReportRecomSupers { get; set; }
    }
}
