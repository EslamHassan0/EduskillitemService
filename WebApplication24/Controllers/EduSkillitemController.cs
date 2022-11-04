using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.Service.Edu_skillitemService;
using static WebApplication24.Service.Edu_skillitemService.EduSkillitemService;

namespace WebApplication24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EduSkillitemController : ControllerBase
    {
        IEduSkillitemService _IEduSkillitemService;
        public EduSkillitemController(IEduSkillitemService service)
        {
            _IEduSkillitemService = service;
        }
        [HttpGet]
        [Route("~/getEduSkillItem")]
        public IActionResult GetAllEduField()
        {
            try
            {
                var EduSkillItem = _IEduSkillitemService.GetEduFieldSkillItemlList();
                if (EduSkillItem == null) return NotFound();
                return Ok(EduSkillItem);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/getEduSkillItembyid/{id:int}")]
        public IActionResult GetgetEduSkillItemById(int id)
        {
            try
            {
                var EduField = _IEduSkillitemService.GetEduFieldSkillItemDetailsById(id);
                if (EduField == null) return NotFound();
                return Ok(EduField);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/postEduSkillItem")]
        public IActionResult SaveEduSkillItem([FromBody] EduSkillItem EduFieldSkillItemModel)
        {
            try
            {
                var model = _IEduSkillitemService.SaveEduFieldSkillItem(EduFieldSkillItemModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("~/UpdateEduSkillItem")]
        public IActionResult UpdateEduSkillItem([FromBody] EduSkillItem EduSkillItemModel)
        {
            try
            {
                var model = _IEduSkillitemService.UpdateEduFieldSkillItem(EduSkillItemModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("~/DeleteEduSkillItem/{id:int}")]
        public IActionResult DeleteEduSkillItem(int SkillItemId)
        {
            try
            {
                var model = _IEduSkillitemService.DeleteEduFieldSkillItem(SkillItemId);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }










    }
}
