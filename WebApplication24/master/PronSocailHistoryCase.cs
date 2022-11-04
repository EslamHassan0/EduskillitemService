using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class PronSocailHistoryCase
    {
        public int SocailHisId { get; set; }
        public int StudentId { get; set; }
        public int? AssessmentId { get; set; }
        public string ChildLive { get; set; }
        public string RelationBparent { get; set; }
        public string ArrangeChild { get; set; }
        public string SocialStatusParents { get; set; }
        public string CommunicationDisorder { get; set; }

        public virtual PronAssessment Assessment { get; set; }
    }
}
