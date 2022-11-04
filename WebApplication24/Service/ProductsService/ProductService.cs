using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;

namespace WebApplication24.Service.ProductsService
{
    public class ProductService :IProductservice
    {
        private erpContext _context;
        public ProductService(erpContext context)
        {
            _context = context;
        }
        public class PrductList
        {
            public int ProductId { get; set; }
            public string Productname { get; set; }
            public int? Price { get; set; }
            public int? Sales { get; set; }
            public int? SalesMonths { get; set; }
        }
        public Product Getmaxproductandmin()
        {

            try
            {

                Product _list = new Product();

                var maxItems = (from x in _context.Products select new { x.Sales, }).Max();
                var minItems = (from x in _context.Products select new { x.Sales, }).Min();







                return _list;



            }
            catch (Exception ex)
            {
                throw;
                return null;
            }


        }
        public List<PrductList> GetSalesAndsalesManth()
        {

            try
            {

                List<PrductList> _list = new List<PrductList>();

                var items = (from x in _context.Products group x by new { x.Productname,x.SalesMonths } into g 
                             select new {Productname =g.Key.Productname, SalesMonths=g.Key.SalesMonths, Sales=g.Sum(x=>x.Sales) } ).ToList();
                
                foreach (var itm in items)
                {
                    PrductList _li = new PrductList();
                    _li.Sales = itm.Sales;
                    _li.SalesMonths = itm.SalesMonths;
                    _li.Productname = itm.Productname;
                   


                    _list.Add(_li);

                }


                return _list;



            }
            catch (Exception)
            {
                throw;
                return null;
            }


        }



    }
}
