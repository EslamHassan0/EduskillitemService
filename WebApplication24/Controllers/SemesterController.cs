using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.Service.SemesterService;
using static WebApplication24.Service.SemesterService.SemesterService;

namespace WebApplication24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        ISemesterService _IYearStudyService;
        public SemesterController(ISemesterService service)
        {
            _IYearStudyService = service;
        }
        [HttpGet]
        [Route("~/getSemester")]
        public IActionResult GetSemesterAndYearStudy()
        {
            try
            {
                var _Semester = _IYearStudyService.GetSemesterAndYearStudyList();
                if (_Semester == null) return NotFound();
                return Ok(_Semester);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/getSemesterbyid/{SemesterId:int}")]
        public IActionResult getSemesterbyid(int SemesterId)
        {
            try
            {
                var _Semester = _IYearStudyService.GetYearStudyById(SemesterId);
                if (_Semester == null) return NotFound();
                return Ok(_Semester);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/getSemesterbyYear/{YearStudyId:int}")]
        public IActionResult getSemesterbyYear(int YearStudyId)
        {
            try
            {
                var _Semester = _IYearStudyService.GetYearStudyByYear(YearStudyId);
                if (_Semester == null) return NotFound();
                return Ok(_Semester);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }




        [HttpPost]
        [Route("~/postSemester")]
        public IActionResult SaveSemester([FromBody] SemesterList SemesterListModel)
        {
            try
            {
                var model = _IYearStudyService.SaveSemester(SemesterListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("~/UpdateSemester")]
        public IActionResult UpdateSemester([FromBody] SemesterList SemesterListModel)
        {
            try
            {
                var model = _IYearStudyService.updateSemester(SemesterListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("~/DeleteSemester/{Semesterid:int}")]
        public IActionResult DeleteSemester(int SemesterId)
        {
            try
            {
                var model = _IYearStudyService.DeleteSemester(SemesterId);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }





    }
}
