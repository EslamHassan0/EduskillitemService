using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Service;
using WebApplication24.Service.clMenuServices;
using static WebApplication24.Service.clMenuServices.clMenuServices;

namespace WebApplication24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClMenuServiceController : ControllerBase
    {
        IclMenuServices _IclMenuServices;
        public ClMenuServiceController(IclMenuServices service)
        {
            _IclMenuServices = service;
        }
        [HttpPost]
        [Route("~/ClMenuService/{Discountvalue:float}")]
        public IActionResult SaveclMenu( clMenuitem clMenuitemListModel, float Discountvalue)
        {
            try
            {
                var model = _IclMenuServices.SaveclMenu( clMenuitemListModel, Discountvalue);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/GetmaxSalaryandmin")]
        public IActionResult GetmaxSalaryandmin()
        {
            try
            {
                var Salary = _IclMenuServices.GetmaxSalaryandmin();
                if (Salary == null) return NotFound();
                return Ok(Salary);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }









    }
}
