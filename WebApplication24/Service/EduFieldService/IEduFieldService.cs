using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.ViewModels;
using static WebApplication24.Service.EduFieldService.EduFieldService;

namespace WebApplication24.Service.EduFieldService
{
   public interface IEduFieldService
    {
        List<EduField> GetEduFieldList();
        EduField GetEduFieldDetailsById(int EduFieldId);
        ResponseModel SaveEduField(EduField EduFieldModel);
        ResponseModel SaveEduSkill(EduSkillList EduSkillListModel);
        ResponseModel DeleteEduField(int EduFieldId);
        ResponseModel SavePsyProblem(broplemsList broplemsListModel);
        PsyProblemGroup GetPsyProblemGroupById(int PsyProblemGroupID);




    }
}
