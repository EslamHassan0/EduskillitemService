using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.ViewModels;
using static WebApplication24.Service.Edu_skillitemService.EduSkillitemService;

namespace WebApplication24.Service.Edu_skillitemService
{
   public interface IEduSkillitemService
    {
        List<EduSkillItemList1> GetEduFieldSkillItemlList();
        EduFieldSkillItem GetEduFieldSkillItemDetailsById(int SkillId);
        ResponseModel SaveEduFieldSkillItem(EduSkillItem EduFieldSkillItemModel);
        ResponseModel UpdateEduFieldSkillItem(EduSkillItem EduSkillItemModel);
        ResponseModel DeleteEduFieldSkillItem(int SkillItemId);





    }
}
