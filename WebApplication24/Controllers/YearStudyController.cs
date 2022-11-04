using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Service.YearStudyService;
using static WebApplication24.Service.YearStudyService.YearStudyService;

namespace WebApplication24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YearStudyController : ControllerBase
    {

        IYearStudyService _IYearStudyService;
        public YearStudyController(IYearStudyService service)
        {
            _IYearStudyService = service;
        }
        [HttpGet]
        [Route("~/getYearStudy")]
        public IActionResult GetAllYearStudy()
        {
            try
            {
                var YearStudy = _IYearStudyService.GetYearStudyList();
                if (YearStudy == null) return NotFound();
                return Ok(YearStudy);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/getYearStudyById/{id:int}")]
        public IActionResult getYearStudyById(int YearStudyId)
        {
            try
            {
                var YearStudy = _IYearStudyService.GetYearStudyById(YearStudyId);
                if (YearStudy == null) return NotFound();
                return Ok(YearStudy);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/postYearStudy")]
        public IActionResult SaveYearStudy([FromBody] SaveYearStudyItem SaveYearStudyItemModel)
        {
            try
            {
                var model = _IYearStudyService.SaveYearStudy(SaveYearStudyItemModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("~/UpdateYearStudy")]
        public IActionResult UpdateYearStudy([FromBody] SaveYearStudyItem SaveYearStudyItemModel)
        {
            try
            {
                var model = _IYearStudyService.updateYearStudy(SaveYearStudyItemModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("~/DeleteYearStudy/{id:int}")]
        public IActionResult DeleteYearStudy(int YearStudyId)
        {
            try
            {
                var model = _IYearStudyService.DeleteYearStudy(YearStudyId);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }









    }
}
