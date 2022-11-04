using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Service.SupportService;
using static WebApplication24.Service.SupportService.SupportService;

namespace WebApplication24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportController : ControllerBase
    {

        ISupportService _ISupportService;
        public SupportController(ISupportService service)
        {
            _ISupportService = service;
        }
        [HttpGet]
        [Route("~/GetSupportbyclinetid/{ClinetId:int}")]
        public IActionResult GetSupportbyclinetid(int ClinetId)
        {
            try
            {
                var _Support = _ISupportService.GetSupportbyclinetid(ClinetId);
                if (_Support == null) return NotFound();
                return Ok(_Support);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/GetSupportById/{SupportId:int}")]
        public IActionResult GetSupportById(int SupportId)
        {
            try
            {
                var _Support = _ISupportService.GetSupportById(SupportId);
                if (_Support == null) return NotFound();
                return Ok(_Support);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/GetticketByClinetid/{Id:int}")]
        public IActionResult GetticketByClinetid(int Id)
        {
            try
            {
                var _Support = _ISupportService.GetticketByClinetid(Id);
                if (_Support == null) return NotFound();
                return Ok(_Support);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }







        [HttpDelete]
        [Route("~/DeleteSuppor/{Semesterid:int}")]
        public IActionResult DeleteSuppor(int ClinetId)
        {
            try
            {
                var model = _ISupportService.DeleteSuppor(ClinetId);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/saveSupport")]
        public IActionResult SaveSupport([FromBody] SupporList SupporListModel)
        {
            try
            {
                var model = _ISupportService.SaveSupport(SupporListModel );
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

       
       
    }  
}
