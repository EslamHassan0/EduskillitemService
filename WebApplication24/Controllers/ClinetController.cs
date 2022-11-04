using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Service.ClinetService;
using static WebApplication24.Service.ClinetService.ClinetService;

namespace WebApplication24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinetController : ControllerBase
    {
        IClinetService _IClinetService;
        public ClinetController(IClinetService service)
        {
            _IClinetService = service;
        }
        [HttpGet]
        [Route("~/getClinet")]
        public IActionResult GetClinetList()
        {
            try
            {
                var Clinet = _IClinetService.GetClinetList();
                if (Clinet == null) return NotFound();
                return Ok(Clinet);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/getClinetById/{Clinetid:int}")]
        public IActionResult getClinetById(int Clinetid)
        {
            try
            {
                var Clinet = _IClinetService.GetClinetById(Clinetid);
                if (Clinet == null) return NotFound();
                return Ok(Clinet);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/SaveClinet")]
        public IActionResult SaveClinet([FromBody] Clinetlist ClinetListModel)
        {
            try
            {
                var model = _IClinetService.SaveClinet(ClinetListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("~/UpdateClinet")]
        public IActionResult UpdateClinet([FromBody] Clinetlist ClinetListModel)
        {
            try
            {
                var model = _IClinetService.updateClinet(ClinetListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("~/DeleteClinet")]
        public IActionResult DeleteClinet(int Clinetid)
        {
            try
            {
                var model = _IClinetService.DeleteClinet(Clinetid);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
