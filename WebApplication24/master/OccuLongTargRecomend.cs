using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class OccuLongTargRecomend
    {
        public OccuLongTargRecomend()
        {
            OccuPlanLongTargets = new HashSet<OccuPlanLongTarget>();
        }

        public int RecomendationId { get; set; }
        public string Recomendation { get; set; }

        public virtual ICollection<OccuPlanLongTarget> OccuPlanLongTargets { get; set; }
    }
}
