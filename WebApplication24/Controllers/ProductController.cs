using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Service.ProductsService;

namespace WebApplication24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        IProductservice _IProductservice;
        public ProductController(IProductservice service)
        {
            _IProductservice = service;
        }
        [HttpGet]
        [Route("~/getmaxandminproduct")]
        public IActionResult Getmaxproductandmin()
        {
            try
            {
                var product = _IProductservice.Getmaxproductandmin();
                if (product == null) return NotFound();
                return Ok(product);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/GetSalesAndsalesManth")]
        public IActionResult GetSalesAndsalesManth()
        {
            try
            {
                var _Product = _IProductservice.GetSalesAndsalesManth();
                if (_Product == null) return NotFound();
                return Ok(_Product);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }





    }
}
