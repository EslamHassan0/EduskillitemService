using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class ResidRepFavActivity
    {
        public ResidRepFavActivity()
        {
            ResidReportFavActivities = new HashSet<ResidReportFavActivity>();
        }

        public int FavActivityId { get; set; }
        public string FavActivity { get; set; }

        public virtual ICollection<ResidReportFavActivity> ResidReportFavActivities { get; set; }
    }
}
