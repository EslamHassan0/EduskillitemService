using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiBcastudent
    {
        public int Bcaid { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public float? HeightCm { get; set; }
        public float? Icwl { get; set; }
        public string Ecwl { get; set; }
        public string Icwlnrange { get; set; }
        public string Ecwlnrange { get; set; }
        public float? ActualWeight { get; set; }
        public float? LeanMuscle { get; set; }
        public float? FatKg { get; set; }
        public float? Bmi { get; set; }
        public float? WeightCtrlKg { get; set; }
        public float? MasclesCtrlKg { get; set; }
        public float? IdealWeightKg { get; set; }
        public float? MusclKg { get; set; }
        public float? Fats { get; set; }
        public int? Bmrid { get; set; }
        public float? FatCtrl { get; set; }
        public string Notes { get; set; }
        public byte Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }
        public string Attachment { get; set; }

        public virtual NutiBmr Bmr { get; set; }
        public virtual Student Student { get; set; }
    }
}
