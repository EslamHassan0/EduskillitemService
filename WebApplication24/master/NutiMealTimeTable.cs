using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiMealTimeTable
    {
        public int MealTimeTabId { get; set; }
        public int StudentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int FoodId { get; set; }
        public int DietId { get; set; }
        public string Action { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte SessionId { get; set; }
        public string Attachment { get; set; }

        public virtual NutiDiet Diet { get; set; }
        public virtual NutiFood Food { get; set; }
        public virtual Student Student { get; set; }
    }
}
