using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.ViewModels;
using static WebApplication24.Service.YearStudyService.YearStudyService;

namespace WebApplication24.Service.YearStudyService
{
   public interface IYearStudyService
    {
        List<YearStudy> GetYearStudyList();
        YearStudy GetYearStudyById(int YearStudyId);
        ResponseModel SaveYearStudy(SaveYearStudyItem SaveYearStudyItemModel);
        ResponseModel updateYearStudy(SaveYearStudyItem SaveYearStudyItemModel);
        ResponseModel DeleteYearStudy(int YearStudyId);
     






    }
}
