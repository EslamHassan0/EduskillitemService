using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Productname { get; set; }
        public int? Price { get; set; }
        public int? Sales { get; set; }
        public int? SalesMonths { get; set; }
    }
}
