using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class VwNutiAssessmentStudent
    {
        public int StudentId { get; set; }
        public int Serial { get; set; }
        public string StudentNameArabic { get; set; }
        public string StudentNameEnglish { get; set; }
        public bool SexType { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateRegister { get; set; }
        public int? FileNo { get; set; }
        public string MedicalDiagnosis { get; set; }
        public string NationalityName { get; set; }
        public string SectionName { get; set; }
        public int? SectionId { get; set; }
        public int? RoomId { get; set; }
        public string SuperVisouer { get; set; }
        public string CareGiver { get; set; }
    }
}
