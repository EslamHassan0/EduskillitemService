using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using static WebApplication24.Service.ProductsService.ProductService;

namespace WebApplication24.Service.ProductsService
{
   public interface IProductservice
    {
        Product Getmaxproductandmin();
        List<PrductList> GetSalesAndsalesManth();








    }
}
