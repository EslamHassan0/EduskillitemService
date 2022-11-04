using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwRptPsyCaseStudy
    {
        public int StudentId { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public DateTime Birthday { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public string Question { get; set; }
        public string NationalityName { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
