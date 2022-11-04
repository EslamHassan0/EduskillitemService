using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.Service.EduFieldService;
using static WebApplication24.Service.EduFieldService.EduFieldService;

namespace WebApplication24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EduFieldController : ControllerBase
    {
        IEduFieldService _EduFieldService;
        public EduFieldController(IEduFieldService service)
        {
            _EduFieldService = service;
        }
        [HttpGet]
        [Route("~/getEduField")]
        public IActionResult GetAllEduField()
        {
            try
            {
                var EduField = _EduFieldService.GetEduFieldList();
                if (EduField == null) return NotFound();
                return Ok(EduField);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/getEduFieldbyid/{id:int}")]
        public IActionResult GetEduFieldById(int id)
        {
            try
            {
                var EduField = _EduFieldService.GetEduFieldDetailsById(id);
                if (EduField == null) return NotFound();
                return Ok(EduField);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/postEduField")]
        public IActionResult SaveEduField(EduField EduFieldModel)
        {
            try
            {
                var model = _EduFieldService.SaveEduField(EduFieldModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("~/DeleteEduField/{id:int}")]
        public IActionResult DeleteEduField(int idEduField)
        {
            try
            {
                var model = _EduFieldService.DeleteEduField(idEduField);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("~/EduSkillpost")]
        public IActionResult SaveEduSkilllist([FromBody] EduSkillList EduSkillListModel)
        {
            try
            {
                var model = _EduFieldService.SaveEduSkill(EduSkillListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
         

        }
        [HttpGet]
        [Route("~/GetPsyProblemGroupById/{id:int}")]
        public IActionResult GetPsyProblemGroupById(int id)
        {
            try
            {
                var ProblemGroup = _EduFieldService.GetPsyProblemGroupById(id);
                if (ProblemGroup == null) return NotFound();
                return Ok(ProblemGroup);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/broplemspost")]
        public IActionResult Savebroplemslist([FromBody] broplemsList broplemsListModel)
        {
            try
            {
                var model = _EduFieldService.SavePsyProblem(broplemsListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }



        }
    }
}
